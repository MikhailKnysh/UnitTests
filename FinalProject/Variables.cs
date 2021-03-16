using System;

namespace FinalProject
{
    public static class Variables
    {
        public static double Formula(double a, double b)
        {
            double result;

            if (a != b)
            {
                result = (5 * a + b * b) / (b - a);

                return Math.Round(result, 3);
            }

            throw new DivideByZeroException("a == b");
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int[] DivisionAndRemainder(int a, int b)
        {
            int resultOfDivision;
            int remainder;

            if (b != 0)
            {
                resultOfDivision = a / b;
                remainder = a % b;

                return new int[] { resultOfDivision, remainder };
            }

            throw new DivideByZeroException("a == b");
        }

        public static double Equation(double a, double b, double c)
        {
            double result;

            if (a != 0)
            {
                result = (c - b) / a;

                return Math.Round(result, 3);
            }

            throw new DivideByZeroException("a == 0");
        }

        public static double[] StraightLineEquation(double x1, double y1, double x2, double y2)
        {
            if (x1 != x2)
            {
                double a = (y2 - y1) / (x2 - x1);
                double b = y1 - a * x1;

                return new double[] {
                    Math.Round(a, 3),
                    Math.Round(b, 3)
                };
            }

            throw new DivideByZeroException("x1 == x2");
        }
    }
}
