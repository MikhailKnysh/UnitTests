using System;

namespace FinalProject
{
    public static class Branching
    {
        public enum Quater
        {
            Center,
            CoordinateAxis,
            First,
            Second,
            Third,
            Fourth
        }

        public static double GetResultAfterComparison(double a, double b)
        {
            double result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return Math.Round(result, 3);
        }

        public static Quater FindQuater(double x, double y)
        {
            Quater quater = Quater.CoordinateAxis;

            if (x > 0 && y > 0)
            {
                quater = Quater.First;
            }
            else if (x < 0 && y > 0)
            {
                quater = Quater.Second;
            }
            else if (x < 0 && y < 0)
            {
                quater = Quater.Third;
            }
            else if (x > 0 && y < 0)
            {
                quater = Quater.Fourth;
            }
            else if (x == 0 && y == 0)
            {
                quater = Quater.Center;
            }

            return quater;
        }

        public static void GetNumbersInAscendingOrder(ref int a, ref int b, ref int c)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (a > c)
            {
                Swap(ref a, ref c);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }
        }

        public static double[] GetRootsOfSquareEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("a == 0");
            }

            double D = b * b - 4 * a * c;
            double[] result;

            if (D > 0)
            {
                result = new[]
                {
                        (-b + Math.Sqrt(D)) / (2 * a),
                        (-b - Math.Sqrt(D)) / (2 * a)
                    };
            }
            else if (D == 0)
            {
                result = new[] { -b / (2 * a) };
            }
            else
            {
                result = null;
            }

            return result;
        }

        public static string GetNumberByWords(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }

            string result;
            string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] elevenToNineteen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number >= 11 && number <= 19)
            {
                result = elevenToNineteen[number % 10 - 1];
            }
            else if (number % 10 == 0)
            {
                result = tens[number / 10 - 1];
            }
            else
            {
                result = tens[number / 10 - 1] + " " + units[number % 10];
            }

            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
