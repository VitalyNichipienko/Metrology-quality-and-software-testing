using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;


namespace RationalSoftwareTesting
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            TestController testController = new TestController();
            DeterminingTheWeightIndicatorsOfActors form = new DeterminingTheWeightIndicatorsOfActors(testController);
            form.Show();
        }


        private void buttonResults_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Test data(*.json)|*.json"; ;

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = openFileDialog.FileName;
            string jsonString = File.ReadAllText(fileName);
            TestData testData = JsonConvert.DeserializeObject<TestData>(jsonString);

            ResultsViewer form = new ResultsViewer(testData);
            form.Show();
        }
    }
}
