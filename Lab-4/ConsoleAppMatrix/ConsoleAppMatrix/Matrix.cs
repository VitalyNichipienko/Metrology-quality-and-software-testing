using System;


namespace ConsoleAppMatrix
{
    public class MyException : Exception
    {
        public MyException(string s) : base(s) { }
    }



    public class Matrix
    {
        private int[,] m;



        public int I { get; set; }
        public int J { get; set; }



        public Matrix(int i, int j)
        {
            if (i <= 0)
                throw new MyException(string.Format("Недопустимое значение i = {0}", i));
            if (j <= 0)
                throw new MyException(string.Format("Недопустимое значение j = {0}", j));
            I = i;
            J = j;
            m = new int[i, j];
        }


        public int this[int i, int j]
        {
            get
            {
                if (i < 0 | i > I - 1)
                    throw new MyException(string.Format("Неверное значение i = {0}", i));
                if (j < 0 | j > J - 1)
                    throw new MyException(string.Format("Неверное значение j = {0}", j));
                return m[i, j];
            }
            set
            {
                if (i < 0 | i > I - 1)
                    throw new MyException(string.Format("Неверное значение i = {0}", i));
                if (j < 0 | j > J - 1)
                    throw new MyException(string.Format("Неверное значение j = {0}", j)); m[i, j] = value;
            }
        }


        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.I, a.J);

            for (int i = 0; i < a.I; i++)
            {
                for (int j = 0; j < a.J; j++)
                {
                    c[i, j] = a.m[i, j] + b.m[i, j];
                }
            }

            return c;
        }


        public static bool operator ==(Matrix a, Matrix b) 
        { 
            bool q = true;

            for (int i = 0; i < a.I; i++)
            {
                for (int j = 0; j < a.J; j++)
                {
                    if (a[i, j] != b[i, j])
                    {
                        q = false; break;
                    }
                }
            }

            return q; 
        }


        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }


        public void Show()
        { 
            for (int i = 0; i < I; i++) 
            { 
                for (int j = 0; j < J; j++) 
                { 
                    Console.Write("\t" + this[i, j]); 
                } 
                Console.WriteLine(); 
            } 
            Console.WriteLine(); 
        }


        public override bool Equals(object obj) 
        { 
            return (this as Matrix) == (obj as Matrix); 
        }
    }
}
