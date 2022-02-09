using System;


namespace ProbabilisticModelingOfProgramMetricCharacteristics
{
    class Program
    {
        private static int n1 = 16; 
        private static int n2 = 32;
        private static int n3 = 64;
        private static int n4 = 128;



        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the available dictionary size");
                Console.WriteLine("1 - " + n1.ToString());
                Console.WriteLine("2 - " + n2.ToString());
                Console.WriteLine("3 - " + n3.ToString());
                Console.WriteLine("4 - " + n4.ToString());

                string cmd = Console.ReadLine();

                ProbabilisticModelOfTheProgramWritingProcess model;

                model = new ProbabilisticModelOfTheProgramWritingProcess(18);
                Console.WriteLine("L = " + model.L);


                switch (cmd)
                {
                    case ("1"): model = new ProbabilisticModelOfTheProgramWritingProcess(n1); break;
                    case ("2"): model = new ProbabilisticModelOfTheProgramWritingProcess(n2); break;
                    case ("3"): model = new ProbabilisticModelOfTheProgramWritingProcess(n3); break;
                    case ("4"): model = new ProbabilisticModelOfTheProgramWritingProcess(n4); break;
                    default: model = new ProbabilisticModelOfTheProgramWritingProcess(n1); break;
                }

                Console.WriteLine("L = " + model.L);
                Console.WriteLine("D = " + model.D);
                Console.WriteLine("Sqrt(D) = " + model.SqrtD);
                Console.WriteLine("S = " + model.S);
                Console.WriteLine();
            }
        }
    }
}
