using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace RationalSoftwareTesting
{
    public class TestController
    {       
        private TestData testData;



        public TestData TestData => testData;



        public TestController()
        {
            testData = new TestData();
        }



        public void CalculateA(List<double> values) 
        {
            testData.A = 0;

            foreach(var value in values)
            {
                testData.A += value;
            }
        }


        public void CalculateUCP(List<double> values) 
        {
            testData.UCP = 0;

            foreach (var value in values)
            {
                testData.UCP += value;
            }

            CalculateUUCP();
        }


        public void CalculateUCP()
        {
            testData.UCP = testData.UUCP * testData.TCF * testData.EF;
        }


        public void CalculateUUCP() 
        {
            testData.UUCP = testData.A + testData.UCP;
        }


        public void CalculateTCF(double value) 
        {
            testData.TCF = 0.6f + (0.01f * value);
        }


        public void CalculateEF(double value) 
        {
            testData.EF = 1.4f + (-0.03f * value);
        }


        public bool TryGetNumberManHoursForUCP(out double numberManHoursForUCP)
        {
            int sum = 0;
            numberManHoursForUCP = testData.NumberManHoursForUCP = 0;

            for (int i = 0; i <= 5; i++)
            {
                if (testData.environmentalIndicators[i].Item3 < 3)
                {
                    sum++;
                }
            }
            for (int i = 6; i < 8; i++)
            {
                if (testData.environmentalIndicators[i].Item3 > 3)
                {
                    sum++;
                }
            }

            if (sum <= 2)
            {
                numberManHoursForUCP = testData.NumberManHoursForUCP = 20;
                return true;
            }
            else
            {
                if (sum > 2 && sum < 5)
                {
                    numberManHoursForUCP = testData.NumberManHoursForUCP = 28;
                    return true;
                }
                else
                {
                    return false;
                }
            }            
        }


        public double GetNumberManHours(double numberManHoursForUCP)
        {
            testData.NumberManHours = testData.UCP * numberManHoursForUCP;
            return testData.NumberManHours;
        }


        public void SaveData(string fileName)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(testData));
        }
    }
}
