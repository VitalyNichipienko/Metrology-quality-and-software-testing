using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace RationalSoftwareTesting
{
    public partial class DeterminingTheLevelOfQualificationOfDevelopers : Form
    {
        private TestController testController;
        private List<string> descriptions = new List<string>() { "description1", "description2", "description3", "description4",
                                                                "description5", "description6","description7","description8",};
        private int numberFactors = 8;



        private event Action OnFormUpdate;



        public DeterminingTheLevelOfQualificationOfDevelopers(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;

            OnFormUpdate += UpdateNumberEF;

            OnFormUpdate?.Invoke();

            if (testController.TestData.environmentalIndicators.Count == 0)
            {
                for (int i = 0; i < numberFactors; i++)
                {
                    dataGridView1.Rows.Add("F" + (i + 1).ToString(), descriptions[i], 0, 0, 0);
                    testController.TestData.environmentalIndicators.Add((descriptions[i], 0, 0));
                }
            }
            else
            {
                for (int i = 0; i < numberFactors; i++)
                {
                    dataGridView1.Rows.Add("F" + (i + 1).ToString(),
                        testController.TestData.environmentalIndicators[i].Item1,
                        testController.TestData.environmentalIndicators[i].Item2,
                        testController.TestData.environmentalIndicators[i].Item3,
                        testController.TestData.environmentalIndicators[i].Item2 * testController.TestData.environmentalIndicators[i].Item3);
                }
            }
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateNumberEF;

            DeterminingTheTechnicalComplexityOfTheProject form = new DeterminingTheTechnicalComplexityOfTheProject(testController);
            form.Show();
            Close();
        }


        private void buttonContinue_Click(object sender, EventArgs e)
        {
            OnFormUpdate -= UpdateNumberEF;

            AssessmentTheLaboriousnessOfTheProject form = new AssessmentTheLaboriousnessOfTheProject(testController);
            form.Show();
            Close();
        }


        private void UpdateNumberEF()
        {
            double value = 0;

            foreach (var elem in testController.TestData.environmentalIndicators)
            {
                value += elem.Item2 * elem.Item3;
            }

            testController.CalculateEF(value);

            textBoxEF.Text = testController.TestData.EF.ToString();
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != numberFactors)
                return;


            for (int i = 0; i < numberFactors; i++)
            {
                if (Convert.ToDouble(dataGridView1[3, i].Value) < 0)
                {
                    dataGridView1[3, i].Value = 0;
                }
                else
                {
                    if (Convert.ToDouble(dataGridView1[3, i].Value) > 5)
                    {
                        dataGridView1[3, i].Value = 5;
                    }
                }

                double value1 = Convert.ToDouble(dataGridView1[2, i].Value, CultureInfo.InvariantCulture.NumberFormat);
                double value2 = Convert.ToDouble(dataGridView1[3, i].Value);
                dataGridView1[4, i].Value = value1 * value2;

                testController.TestData.environmentalIndicators[i] = ((dataGridView1[1, i].Value.ToString(),
                                                                    Convert.ToDouble(dataGridView1[2, i].Value, CultureInfo.InvariantCulture.NumberFormat),
                                                                    Convert.ToInt32(dataGridView1[3, i].Value)));
            }

            OnFormUpdate?.Invoke();
        }
    }
}
