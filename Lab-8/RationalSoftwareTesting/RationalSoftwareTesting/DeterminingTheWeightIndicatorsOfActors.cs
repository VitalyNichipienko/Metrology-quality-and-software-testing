using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace RationalSoftwareTesting
{
    public partial class DeterminingTheWeightIndicatorsOfActors : Form
    {
        private TestController testController;
        private Dictionary<string, int> typesCharacters = new Dictionary<string, int>()
        {
            { "Простое", 1 },
            { "Среднее", 2 },
            { "Сложное", 3 }
        };



        private event Action OnFormUpdate;



        public DeterminingTheWeightIndicatorsOfActors(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;
            comboBox.DataSource = typesCharacters.Keys.ToList();

            OnFormUpdate += UpdateListView;
            OnFormUpdate += UpdateNumberA;

            OnFormUpdate?.Invoke();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return;

            testController.TestData.actors.Add(textBox.Text, comboBox.SelectedItem.ToString());
            OnFormUpdate?.Invoke();

            textBox.Clear();
            textBox.Focus();
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count <= 0)
                return;

            testController.TestData.actors.Remove(listView.SelectedItems[0].Text);
            OnFormUpdate?.Invoke();
        }


        private void buttonContinue_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateListView;
            OnFormUpdate -= UpdateNumberA;

            DeterminingTheWeightIndicatorsOfUseCases form = new DeterminingTheWeightIndicatorsOfUseCases(testController);
            form.Show();
            Close();
        }


        private void UpdateListView()
        {
            listView.Items.Clear();

            foreach (var actor in testController.TestData.actors)
            {
                ListViewItem item = new ListViewItem(actor.Key);
                item.SubItems.Add(actor.Value.ToString());
                listView.Items.Add(item);
            }            
        }


        private void UpdateNumberA()
        {
            List<double> values = new List<double>();

            for (int i = 0; i < listView.Items.Count; i++)
            {
                values.Add(typesCharacters[listView.Items[i].SubItems[1].Text]);
            }

            testController.CalculateA(values);

            textBoxA.Text = testController.TestData.A.ToString();
        }
    }
}
