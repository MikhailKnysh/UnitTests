using System;
using System.Collections.Generic;

namespace FinalProject
{
    public static class Loops
    {
        public static double GetPow(double number, double power)
        {
            double result = number;

            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        public static int[] GetNumbersFrom1To1000ThatDivisibleByGivenNumber(int number)
        {
            int counter = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    ++counter;
                }
            }

            int[] array = new int[counter];
            int size = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    array[size++] = i;
                }
            }

            return array;
        }

        public static int GetQuantityOfPositiveWholeNumbers(int number)
        {
            int counter = 0;

            for (int i = 1; i <= i/2; i++)
            {
                if (i * i < number)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int GetGreatestDivisor(int number)
        {
            int greatestDivisor = 1;

            for (int i = number / 2; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    greatestDivisor = i;
                }
            }

            return greatestDivisor;
        }

        public static int GetSumOfAllNumbersInTheRangeFromAToB(int a, int b)
        {
            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int GetNthNumberOfTheFibonacciSeries(int number)
        {
            int first = 1;
            int second = 1;
            int result;

            for (int i = 2; i <= number; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return first;
        }

        public static int EuclideanAlgorithm(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        public static double BinarySearchForCubicRoot(int value)
        {
            int low = 0;
            int num = Math.Abs(value);
            int high = Math.Abs(value);
            int mid;

            if (num == 1)
            {
                return Math.Sign(value) * num;
            }

            while (true)
            {
                mid = low + (high - low) / 2;
                int cube = mid * mid * mid;

                if (cube == num)
                {
                    return Math.Sign(value) * mid;
                }
                else if (num < cube || mid > 1290)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }

                if (low == high)
                {
                    return -1;
                }
            }
        }

        public static int CountOddDigits(int number)
        {
            int counter = 0;
            int tempDigit;

            while (number != 0)
            {
                tempDigit = number % 10;

                if (tempDigit % 2 != 0)
                {
                    counter++;
                }

                number /= 10;
            }

            return counter;
        }

        public static int MirrorNumber(int number)
        {
            int resultNumber = 0;

            while (number != 0)
            {
                resultNumber += number % 10;
                resultNumber *= 10;
                number /= 10;
            }

            return resultNumber / 10;
        }

        public static int CountNumbersInRange(int number)//
        {
            int counter = 0;
            int tempDigit;
            int i;

            for (int j = 1; j <= number; j++)
            {
                int evenDigitSum = 0;
                int oddDigitsSum = 0;
                i = j;

                while (i != 0)
                {
                    tempDigit = i % 10;

                    if (tempDigit % 2 == 0)
                    {
                        evenDigitSum += tempDigit;
                    }
                    else
                    {
                        oddDigitsSum += tempDigit;
                    }

                    i /= 10;
                }

                if (evenDigitSum > oddDigitsSum)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static bool ContainEqualDigits(int a, int b)
        {
            bool result = false;
            string firstNumber = a.ToString();
            string secondNumber = b.ToString();

            for (int i = 0; i < firstNumber.Length; i++)
            {
                if (StringElementEqualsToChar(secondNumber, firstNumber[i]))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private static bool StringElementEqualsToChar(string str, char ch)
        {
            bool flag = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }
    }
}
