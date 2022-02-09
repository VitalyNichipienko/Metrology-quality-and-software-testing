using System;


namespace ConsoleAppMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Matrix a = new Matrix(3, 3);
                Matrix b = new Matrix(3, 3);
                Matrix c;

                for (int i = 0; i < a.I; i++)
                {
                    for (int j = 0; j < a.J; j++)
                    {
                        a[i, j] = a.J * i + j;
                    }
                }

                a.Show();

                for (int i = 0; i < a.I; i++)
                {
                    for (int j = 0; j < a.J; j++)
                    {
                        b[i, j] = a.J * i + j + 1;
                    }
                }

                b.Show();

                c = a + b;
                c.Show();
            }
            catch (MyException e) 
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
