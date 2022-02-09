using System;
using System.Collections.Generic;


namespace RationalSoftwareTesting
{
    [Serializable]
    public class TestData
    {
        public Dictionary<string, string> actors;
        public Dictionary<string, string> useCases;
        public List<(string, double, int)> technicalComplexityIndicators;
        public List<(string, double, int)> environmentalIndicators;



        public double A { get; set; }

        public double UCP { get; set; }

        public double UUCP { get; set; }

        public double TCF { get; set; }

        public double EF { get; set; }

        public double NumberManHoursForUCP { get; set; }

        public double NumberManHours { get; set; }



        public TestData()
        {
            actors = new Dictionary<string, string>();
            useCases = new Dictionary<string, string>();
            technicalComplexityIndicators = new List<(string, double, int)>();
            environmentalIndicators = new List<(string, double, int)>();
        }
    }
}
