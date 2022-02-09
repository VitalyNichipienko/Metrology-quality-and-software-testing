using System;

namespace ProbabilisticModelingOfProgramMetricCharacteristics
{
    class ProbabilisticModelOfTheProgramWritingProcess
    {
        private static double l = 0;
        private static double d = 0;
        private static double sqrtD = 0;
        private static double s = 0;



        public ProbabilisticModelOfTheProgramWritingProcess(int n)
        {
            l = 0.9 * n * Math.Log(n, 2);
            d = (Math.Pow(Math.PI, 2) * Math.Pow(n, 2) / 6.0);
            sqrtD = Math.Sqrt(d);
            s = 1 / (2 * Math.Log(n, 2));
        }



        public double L => l;
        public double D => d;
        public double SqrtD => sqrtD;
        public double S => s;
    }
}
