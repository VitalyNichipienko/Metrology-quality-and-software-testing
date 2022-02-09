using System;


namespace Calculation_of_metric_characteristics_of_PS
{
    class ModelOfCalculatingTheMetricCharacteristicsOfPS
    {
        private int i = 0;
        private double k = 0;
        private double k_ = 0;
        private double n = 0;
        private double Nk = 0;
        private double Vk = 0;
        private double v = 0;
        private double p = 0;
        private double tk = 0;
        private double b0 = 0;
        private double tao = 0;
        private double ti = 0;



        public ModelOfCalculatingTheMetricCharacteristicsOfPS(int n2, int n2k, int n, int nu)
        {
            k = n2 / 8.0;

            i = (int)Math.Truncate((Math.Log(n2) / 3) + 1);

            for (int j = 2; j <= i; j++)
            {
                k_ += n2 / Math.Pow(8, i-1);
            }
            k_++;

            Nk = 2 * n2k * Math.Log(n2k);

            this.n = k_ * Nk;

            Vk = Nk * Math.Log(2 * n2k);

            v = k_ * Vk;

            p = (3.0 / 8.0) * this.n;

            tk = p / (n * nu);

            b0 = v / 3000;

            tao = 0.5 * tk;

            ti = tao / Math.Log(b0);
        }



        public int I => i;
        public double K => k;        
        public double K_ => k_;
        public double N => n;
        public double V => v;
        public double P => p;
        public double Tk => tk;
        public double B0 => b0;
        public double Ti => ti;
    }
}
