using System;

namespace FinalProject
{
    public static class OneDimensionalArrays
    {
        public static int FindMinElementOfTheArray(int[] arr)
        {
            ValidateArrayState(arr);

            return arr[FindIndexOfMinElementOfTheArray(arr)];
        }

        public static int FindMaxElementOfTheArray(int[] arr)
        {
            ValidateArrayState(arr);

            return arr[FindIndexOfMaxElementOfTheArray(arr)];
        }

        public static int FindIndexOfMinElementOfTheArray(int[] arr)
        {
            ValidateArrayState(arr);

            int minIndex = 0;
            int min = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int FindIndexOfMaxElementOfTheArray(int[] arr)
        {
            ValidateArrayState(arr);

            int maxIndex = 0;
            int max = arr[0];

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int GetSumOfArrayElementsWithOddIndexes(int[] arr)
        {
            ValidateArrayState(arr);

            int sum = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int[] ReverceArray(int[] arr)
        {
            ValidateArrayState(arr);

            for (int i = 0; i <= arr.Length / 2 - 1; i++)
            {
                Swap(ref arr[i], ref arr[arr.Length - i - 1]);
            }

            return arr;
        }

        public static int CountOddElementsOfTheArray(int[] arr)
        {
            ValidateArrayState(arr);

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) % 2 == 1)
                {
                    ++counter;
                }
            }

            return counter;
        }

        public static int[] SwapHalves(int[] arr)
        {
            ValidateArrayState(arr);

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap(ref arr[i], ref arr[arr.Length / 2 + i + arr.Length % 2]);
            }

            return arr;
        }

        public static int[] BubbleSort(int[] arr)
        {
            ValidateArrayState(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            ValidateArrayState(arr);

            int maxIndex;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                maxIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                Swap(ref arr[i], ref arr[maxIndex]);
            }

            return arr;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private static void ValidateArrayState(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array is empty!");
            }
        }
    }
}
