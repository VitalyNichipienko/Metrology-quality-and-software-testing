using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace RationalSoftwareTesting
{
    public partial class DeterminingTheWeightIndicatorsOfUseCases : Form
    {
        private TestController testController;
        private Dictionary<string, int> useCases = new Dictionary<string, int>()
        {
            { "Простой", 5 },
            { "Средний", 10 },
            { "Сложный", 15 }
        };



        private event Action OnFormUpdate;



        public DeterminingTheWeightIndicatorsOfUseCases(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;
            comboBox.DataSource = useCases.Keys.ToList();

            OnFormUpdate += UpdateListView;
            OnFormUpdate += UpdateNumberUCP;

            OnFormUpdate?.Invoke();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return;

            testController.TestData.useCases.Add(textBox.Text, comboBox.SelectedItem.ToString());
            OnFormUpdate?.Invoke();

            textBox.Clear();
            textBox.Focus();
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count <= 0)
                return;

            testController.TestData.useCases.Remove(listView.SelectedItems[0].Text);
            OnFormUpdate?.Invoke();
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateListView;
            OnFormUpdate -= UpdateNumberUCP;

            DeterminingTheWeightIndicatorsOfActors form = new DeterminingTheWeightIndicatorsOfActors(testController);
            form.Show();
            Close();
        }


        private void buttonContinue_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateListView;
            OnFormUpdate -= UpdateNumberUCP;

            DeterminingTheTechnicalComplexityOfTheProject form = new DeterminingTheTechnicalComplexityOfTheProject(testController);
            form.Show();
            Close();
        }


        private void UpdateListView()
        {
            listView.Items.Clear();

            foreach (var useCase in testController.TestData.useCases)
            {
                ListViewItem item = new ListViewItem(useCase.Key);
                item.SubItems.Add(useCase.Value.ToString());
                listView.Items.Add(item);
            }
        }


        private void UpdateNumberUCP()
        {
            List<double> values = new List<double>();

            for (int i = 0; i < listView.Items.Count; i++)
            {
                values.Add(useCases[listView.Items[i].SubItems[1].Text]);
            }

            testController.CalculateUCP(values);

            textBoxUCP.Text = testController.TestData.UCP.ToString();
            textBoxUUCP.Text = testController.TestData.UUCP.ToString();
        }
    }
}
