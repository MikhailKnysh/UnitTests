using System;

namespace FinalProjectLibrary
{
    public class TwoDimensionalArrays
    {
        public static int FindMinElementOfTheTwoDimArray(int[,] matrix)
        {
            ValidateMatrixState(matrix);

            int[] minIndex = FindIndexOfMinElementOfTheTwoDimArray(matrix);

            return matrix[minIndex[0], minIndex[1]];
        }

        public static int FindMaxElementOfTheTwoDimArray(int[,] matrix)
        {
            ValidateMatrixState(matrix);

            int[] maxIndex = FindIndexOfMaxElementOfTheTwoDimArray(matrix);

            return matrix[maxIndex[0], maxIndex[1]]; ;
        }

        public static int[] FindIndexOfMinElementOfTheTwoDimArray(int[,] matrix)
        {
            ValidateMatrixState(matrix);

            int[] minIndex = new int[] { 0, 0 };
            int min = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }

            return minIndex;
        }

        public static int[] FindIndexOfMaxElementOfTheTwoDimArray(int[,] matrix)
        {
            ValidateMatrixState(matrix);

            int[] maxIndex = new int[] { 0, 0 };
            int max = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
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

        public static int GetCounterOfAllSmallestNeighbours(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException("Array is empty!");
            }

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
            ValidateMatrixState(matrix);

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

        private static void ValidateMatrixState(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array is empty!");
            }
        }
    }
}
