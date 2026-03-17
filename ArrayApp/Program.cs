using System;

namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr3 = { 1, 2, 3, 4, 5 };
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            foreach (int num in arr3)
            {
                Console.WriteLine(num);
            }

            // 2D array
            int[,] matrix = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 2, 3 };
            jaggedArray[2] = new int[] { 3, 4 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Array methods
            int[] arr4 = { 5, 2, 8, 1, 3 };
            Array.Sort(arr4);
            Array.Reverse(arr4);
            int index = Array.IndexOf(arr4, 3);
            int[] copy = new int[arr4.Length];
            Array.Copy(arr4, copy, arr4.Length);
        }

        public static int getMinPosition(int[] arr)
        {
            int minPosition = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minPosition])
                {
                    minPosition = i;
                }
            }
            return minPosition;
        }

        public static bool isSymmetric(int[] arr)
        {
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    return false;
                }
            }
            return true;
        }

        public static (long bestSum, int bestRow, int bestColumn) FindBestSum(int[,] matrix)
        {
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestColumn = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    long sum = matrix[i, j] + matrix[i, j + 1]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestColumn = j;
                    }
                }
            }
            return (bestSum, bestRow, bestColumn);
        }
    }
}