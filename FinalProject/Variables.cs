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
            }
            else
            {
                throw new DivideByZeroException("a == b");
            }

            return Math.Round(result, 3);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static double[] DivisionAndRemainder(double a, double b)
        {
            double resultOfDivision;
            double remainder;

            if (b != 0)
            {
                resultOfDivision = a / b;
                remainder = a % b;
            }
            else
            {
                throw new DivideByZeroException("a == b");
            }

            return new double[] { resultOfDivision, remainder };
        }

        public static double Equation(double a, double b, double c)
        {
            double result;

            if (a != 0)
            {
                result = (c - b) / a;
            }
            else
            {
                throw new DivideByZeroException("a == 0");
            }

            return result;
        }

        public static double[] StraightLineEquation(double x1, double y1, double x2, double y2)
        {
            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;

            return new double[] { a, b };
        }
    }
}
