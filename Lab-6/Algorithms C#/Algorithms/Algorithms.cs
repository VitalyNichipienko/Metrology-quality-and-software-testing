using System;


namespace Algorithms
{
    class Algorithms
    {
        public (int, int) FindMinInArray(int[] array)
        {
            int min = int.MaxValue;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return (min, index);
        }


        public int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }


        public int BinarySearch(int[] array, int elem)
        {
            return Array.BinarySearch(array, elem);
        }


        public (int, int) FindMinInMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int min = int.MaxValue;
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        index = i;
                    }
                }
            }

            return (min, index);
        }


        public int[] ReverseArray(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                var t = array[i];
                array[i] = array[j];
                array[j] = t;
            }

            return array;
        }


        public int[] ShiftArrayElements(int[] array, int shiftParameter)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[(i + shiftParameter) % newArray.Length];
            }

            return newArray;
        }


        public int[] ReplaceElements(int[] array, int elem, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elem)
                {
                    array[i] = value;
                }
            }

            return array;
        }
    }
}
