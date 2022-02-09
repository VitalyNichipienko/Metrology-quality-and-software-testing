using System;
using System.Windows.Forms;


namespace RationalSoftwareTesting
{
    public partial class ResultsViewer : Form
    {
        public ResultsViewer(TestData testData)
        {
            InitializeComponent();

            textBoxA.Text = testData.A.ToString();
            textBoxUCP.Text = testData.UCP.ToString();
            textBoxUUCP.Text = testData.UUCP.ToString();
            textBoxTCF.Text = testData.TCF.ToString();
            textBoxEF.Text = testData.EF.ToString();
            textBoxMH.Text = testData.NumberManHours.ToString();

            textBoxInitialData.Text += "--- Actors ---" + Environment.NewLine;
            foreach (var elem in testData.actors)
            {
                textBoxInitialData.Text += elem + Environment.NewLine;
            }

            textBoxInitialData.Text += Environment.NewLine + "--- Use cases ---" + Environment.NewLine;
            foreach (var elem in testData.useCases)
            {
                textBoxInitialData.Text += elem + Environment.NewLine;
            }

            textBoxInitialData.Text += Environment.NewLine + "--- Technical complexity indicators ---" + Environment.NewLine;
            foreach (var elem in testData.technicalComplexityIndicators)
            {
                textBoxInitialData.Text += elem + Environment.NewLine;
            }

            textBoxInitialData.Text += Environment.NewLine + "--- Environmental indicators ---" + Environment.NewLine;
            foreach (var elem in testData.environmentalIndicators)
            {
                textBoxInitialData.Text += elem + Environment.NewLine;
            }
        }
    }
}
