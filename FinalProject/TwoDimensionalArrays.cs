using System;

namespace FinalProjectLibrary
{
    class TwoDimensionalArrays
    {
        public static int FindMinElementOfTheTwoDimArray(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            int min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            return min;
        }

        public static int FindMaxElementOfTheTwoDimArray(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }

        public static int[] FindIndexOfMinElementOfTheTwoDimArray(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            int[] minIndex = new int[] { 0, 0 };
            int min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }

            return minIndex;
        }

        public static int[] FindIndexOfMaxElementOfTheTwoDimArray(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            int[] maxIndex = new int[] { 0, 0 };
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }

            return maxIndex;
        }

        private static bool CheckNeighbours(int[,] matrix, int posX, int posY)
        {
            int minX = (posX - 1 >= 0) ? posX - 1 : 0;
            int maxX = (matrix.GetLength(0) > (posX + 1)) ? posX + 1 : matrix.GetLength(0) - 1;
            int minY = (posY - 1 >= 0) ? posY - 1 : 0;
            int maxY = (matrix.GetLength(1) > (posY + 1)) ? posY + 1 : matrix.GetLength(1) - 1;

            for (int i = minX; i <= maxX; i++)
            {
                for (int j = minY; j <= maxY; j++)
                {
                    if (matrix[posX, posY] < matrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int FifthTask(int[,] matrix)
        {
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    if (CheckNeighbours(matrix, i, j))
                    {
                        ++counter;
                        Console.WriteLine($"find elem: i = {i} j = {j} matrix[{i},{j}] = {matrix[i, j]}");
                    }
                }
            }

            return counter;
        }

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int[,] transposed = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            return transposed;
        }
    }
}
