using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace RationalSoftwareTesting
{
    public partial class DeterminingTheTechnicalComplexityOfTheProject : Form
    {
        private TestController testController;
        private List<int> values = new List<int>() { 0, 1, 2, 3, 4, 5 };



        private event Action OnFormUpdate;



        public DeterminingTheTechnicalComplexityOfTheProject(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;
            comboBox.DataSource = values;

            OnFormUpdate += UpdateListView;
            OnFormUpdate += UpdateNumberTCF;

            OnFormUpdate?.Invoke();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescription.Text) || string.IsNullOrEmpty(textBoxWeight.Text))
                return;

            testController.TestData.technicalComplexityIndicators.Add
                ((textBoxDescription.Text, double.Parse(textBoxWeight.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(comboBox.SelectedItem)));
            OnFormUpdate?.Invoke();

            textBoxDescription.Clear();
            textBoxWeight.Clear();
            textBoxDescription.Focus();
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count <= 0)
                return;

            (string, double, int) item = (listView.SelectedItems[0].SubItems[1].Text,
                Convert.ToDouble(listView.SelectedItems[0].SubItems[2].Text),
                Convert.ToInt32(listView.SelectedItems[0].SubItems[3].Text));

            testController.TestData.technicalComplexityIndicators.Remove(item);
            OnFormUpdate?.Invoke();
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateListView;
            OnFormUpdate -= UpdateNumberTCF;

            DeterminingTheWeightIndicatorsOfUseCases form = new DeterminingTheWeightIndicatorsOfUseCases(testController);
            form.Show();
            Close();
        }


        private void buttonContinue_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateListView;
            OnFormUpdate -= UpdateNumberTCF;

            DeterminingTheLevelOfQualificationOfDevelopers form = new DeterminingTheLevelOfQualificationOfDevelopers(testController);
            form.Show();
            Close();
        }



        private void UpdateListView()
        {
            listView.Items.Clear();

            for (int i = 0; i < testController.TestData.technicalComplexityIndicators.Count; i++)
            {
                ListViewItem item = new ListViewItem("T" + (i + 1));
                item.SubItems.Add(testController.TestData.technicalComplexityIndicators[i].Item1);
                item.SubItems.Add(testController.TestData.technicalComplexityIndicators[i].Item2.ToString());
                item.SubItems.Add(testController.TestData.technicalComplexityIndicators[i].Item3.ToString());
                item.SubItems.Add((testController.TestData.technicalComplexityIndicators[i].Item2 *
                                  testController.TestData.technicalComplexityIndicators[i].Item3).ToString());
                listView.Items.Add(item);
            }
        }


        private void UpdateNumberTCF()
        {
            double value = 0;

            foreach(var elem in testController.TestData.technicalComplexityIndicators)
            {
                value += elem.Item2 * elem.Item3;
            }

            testController.CalculateTCF(value);

            textBoxTCF.Text = testController.TestData.TCF.ToString();
        }
    }
}
