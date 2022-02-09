using System;
using System.Windows.Forms;


namespace RationalSoftwareTesting
{
    public partial class AssessmentTheLaboriousnessOfTheProject : Form
    {
        private TestController testController;



        private event Action OnFormUpdate;



        public AssessmentTheLaboriousnessOfTheProject(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;

            OnFormUpdate += UpdateResult;

            OnFormUpdate?.Invoke();
        }



        private void buttonReturn_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateResult;

            DeterminingTheLevelOfQualificationOfDevelopers form = new DeterminingTheLevelOfQualificationOfDevelopers(testController);
            form.Show();
            Close();
        }


        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Test data(*.json)|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = saveFileDialog.FileName;
            testController.SaveData(fileName);
            MessageBox.Show("Файл сохранен");            
        }


        private void UpdateResult()
        {
            testController.CalculateUCP();

            textBoxUCP.Text = testController.TestData.UCP.ToString();
            textBoxUUCP.Text = testController.TestData.UUCP.ToString();
            textBoxTCF.Text = testController.TestData.TCF.ToString();
            textBoxEF.Text = testController.TestData.EF.ToString();

            textBoxMH.Clear();
            if (testController.TryGetNumberManHoursForUCP(out double value))
            {
                labelMessage.Visible = false;
                value = testController.GetNumberManHours(value);
                textBoxMH.Text = value.ToString();
            }
            else
            {
                labelMessage.Visible = true;
            }
        }
    }
}
