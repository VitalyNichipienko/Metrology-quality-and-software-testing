using System;


namespace Calculation_of_metric_characteristics_of_PS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter n*2");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter N2k");
                int n2k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter n");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter nu");
                int nu = Convert.ToInt32(Console.ReadLine());

                ModelOfCalculatingTheMetricCharacteristicsOfPS model = new ModelOfCalculatingTheMetricCharacteristicsOfPS(n2, n2k, n, nu);

                Console.WriteLine("\n");
                Console.WriteLine("Число модулей нижнего уровня k = " + model.K);
                Console.WriteLine("Число уровней иерархии i = " + model.I);
                Console.WriteLine("Общее число модулей K = " + model.K_);
                Console.WriteLine("Длина программы N = " + model.N);
                Console.WriteLine("Объём V = " + model.V);
                Console.WriteLine("Длина ПС P = " + model.P);
                Console.WriteLine("Календарное время программирования Tk = " + model.Tk);
                Console.WriteLine("Начальное количество ошибок B0 = " + model.B0);
                Console.WriteLine("Надёжность ПС ti = " + model.Ti);
                Console.WriteLine("\n\n\n");
            }
        }
    }
}
