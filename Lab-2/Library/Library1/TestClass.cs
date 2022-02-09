namespace Library1
{
    public class TestClass
    {
        public static (int, int) ArrangeNumbers(int a, int b)
        {
            if (a < b)
                return (a, b);
            else
                return (b, a);
        }


        public static float SumEvenElementsOfMatrix(float[,] inputArray)
        {
            float result = 0.0f;

            foreach (var elem in inputArray)
            {
                if (elem % 2 == 0)
                {
                    result += elem;
                }
            }

            return result;
        }


        public static float SumOddElementsOfTopMatrix(float[,] inputArray)
        {
            float result = 0.0f;

            int rows = inputArray.GetUpperBound(0) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    if (inputArray[i, j] % 2 != 0)
                    {
                        result += inputArray[i, j];
                    }
                }
            }

            return result;
        }
    }
}
