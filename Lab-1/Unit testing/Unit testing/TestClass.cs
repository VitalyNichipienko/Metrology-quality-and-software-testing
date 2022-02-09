using System;
using System.Collections.Generic;


namespace Unit_testing
{
    public class TestClass
    {
        public static double CalculateTheProductOfOddArrayElements(double[] inputArray)
        {
            double answer = 1.0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    answer *= inputArray[i];
                }
            }

            return answer;
        }


        public static double[] ShiftArrayElements(double[] inputArray, int shiftParameter)
        {
            double[] newArray = new double[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                newArray[(i + shiftParameter) % newArray.Length] = inputArray[i];
            }

            return newArray;
        }


        public static int ConvertFractionalPartOfNumberToInteger(int b, string s)
        {
            string[] words = s.Split('.');
            string fractionalPart = words[1];

            double inputNumber = PFracTo10(fractionalPart, b);
            double supportNumber = PIntTo10(Math.Pow(10, fractionalPart.Length).ToString(), b);

            double answer = inputNumber * supportNumber;

            return Int10ToP((int)answer, b);
        }


        private static int PIntTo10(string dec, int p)
        {
            double d = 0.0;
            int num = 0;

            for (var i = 0; i < dec.Length; i++)
            {
                d = (Convert.ToInt32(dec[i]) > 64 && Convert.ToInt32(dec[i]) < 71) ?
                    PCharToInt(dec[i]) : Convert.ToInt32(dec[i]) - 48;

                num += Convert.ToInt32(Math.Pow(p, dec.Length - 1 - i) * d);
            }

            return Convert.ToInt32(num);
        }


        private static double PFracTo10(string frac, int p)
        {
            double dig = 0.0;
            double num = 0.0;

            for (var i = 0; i < frac.Length; i++)
            {
                dig = (Convert.ToInt32(frac[i]) > 64 && Convert.ToInt32(frac[i]) < 71) ?
                    Convert.ToInt32(PCharToInt(frac[i])) : dig = Convert.ToInt32(frac[i]) - 48;

                num += Math.Pow(p, -1 - i) * dig;
            }

            return num;
        }


        private static int Int10ToP(int n, int p)
        {
            string res = "";
            int x;

            while (n != 0)
            {
                x = n % p;
                if (x > 9)
                    res = IntToChar(x) + res;
                else
                    res = x.ToString() + res;
                n = n / p;
            }
            return Convert.ToInt32(res);
        }


        private static int PCharToInt(char sym)
        {
            switch (sym)
            {
                case 'A': return 10;
                case 'B': return 11;
                case 'C': return 12;
                case 'D': return 13;
                case 'E': return 14;
                case 'F': return 15;
                default: return -1; //Error
            }
        }


        private static char IntToChar(int n)
        {
            Dictionary<int, char> dict = new Dictionary<int, char>()
            {
                { 10, 'A' }, { 11, 'B' }, { 12, 'C' }, { 13, 'D' }, { 14, 'E' }, { 15, 'F' }
            };

            foreach (var e in dict)
                if (e.Key == n)
                    return e.Value;

            throw new ArgumentException("Error");
        }
    }
}
