using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.NUnitTest
{
    class BranchingTests
    {
        [TestCase(19, 17, 36)]
        [TestCase(101.1315, -49586.16178, -49485.03)]
        [TestCase(14, 14, 196)]
        [TestCase(342, 676, -334)]
        [TestCase(-1047.84579, -567.3485, -480.497)]
        [TestCase(-197.17838, -197.17838, 38879.314)]
        public static void GetResultAfterComparison_WhenValidABPassed_ShouldReturnResultAfterComparison(
            double a, double b, double excepted)
        {
            double actual = Branching.GetResultAfterComparison(a, b);

            Assert.AreEqual(excepted, actual);
        }

        [TestCase(12.7, 3.4, Branching.Quater.First)]
        [TestCase(-12.7, 3.4, Branching.Quater.Second)]
        [TestCase(-12.7, -3.4, Branching.Quater.Third)]
        [TestCase(12.7, -3.45, Branching.Quater.Fourth)]
        [TestCase(0, 0, Branching.Quater.Center)]
        [TestCase(0, 3, Branching.Quater.CoordinateAxis)]
        [TestCase(3, 0, Branching.Quater.CoordinateAxis)]
        public static void FindQuater_WhenValidXYPassed_ShouldReturnEnumQuater(
            double x, double y, Branching.Quater excepted)
        {
            Branching.Quater actual = Branching.FindQuater(x, y);

            Assert.AreEqual(excepted, actual);
        }

        [TestCase(1, 2, 3, 1, 2, 3)]
        [TestCase(2, 3, 1, 1, 2, 3)]
        [TestCase(3, 2, 1, 1, 2, 3)]
        [TestCase(2, 2, 1, 1, 2, 2)]
        public static void GetNumbersInAscendingOrder_WhenValidParametersPassed_ShouldReturnValuesInAscendingOrder(
            ref int a, ref int b, ref int c, int exceptedA, int exceptedB, int exceptedC)
        {
            Branching.GetNumbersInAscendingOrder(ref a, ref b, ref c);

            Assert.AreEqual(exceptedA, a);
            Assert.AreEqual(exceptedB, b);
            Assert.AreEqual(exceptedC, c);
        }

        [TestCase(1, -8, 12, new double[] { 6, 2 })]
        [TestCase(5, 3, 7, null)]
        [TestCase(1, -6, 9, new double[] { 3 })]
        public static void GetRootsOfSquareEquation_WhenValidABCPassed_ShouldReturnRoots(
            double a, double b, double c, double[] excepted)
        {
            double[] actual = Branching.GetRootsOfSquareEquation(a, b, c);

            Assert.AreEqual(excepted, actual);
        }

        public static void GetRootsOfSquareEquation_WhenValidABCPassed_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Branching.GetRootsOfSquareEquation(0, 2, 15));
        }

        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(16, "sixteen")]
        [TestCase(19, "nineteen")]
        [TestCase(20, "twenty")]
        [TestCase(70, "seventy")]
        [TestCase(90, "ninety")]
        [TestCase(21, "twenty one")]
        [TestCase(37, "thirty seven")]
        [TestCase(59, "fifty nine")]
        [TestCase(99, "ninety nine")]
        public static void GetNumberByWords_WhenValidNumberPassed_ShouldReturnNumberByWords(
            int number, string expected)
        {
            string actual = Branching.GetNumberByWords(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        [TestCase(9)]
        [TestCase(100)]
        [TestCase(110)]
        public static void GetNumberByWords_WhenNumberNotBelongsToTheInterval_ShouldThrowDivideByZeroException(int num)
        {
            Assert.Throws<ArgumentException>(() => Branching.GetNumberByWords(num));
        }
    }
}
