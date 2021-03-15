using NUnit.Framework;
using System;

namespace FinalProject.NUnitTest
{
    public class LoopsTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(99, 0, 1)]
        [TestCase(2, 10, 1024)]
        [TestCase(1290, 3, 2146689000)]
        [TestCase(-5, 3, -125)]
        [TestCase(-16, 2, 256)]
        public void GetResultAfterComparison_WhenValidABPassed_ShouldReturnResultAfterComparison(
            int number, int power, int expected)
        {
            double actual = Loops.GetPow(number, power);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(333, new int[] { 333, 666, 999 })]
        [TestCase(125, new int[] { 125, 250, 375, 500, 625, 750, 875, 1000 })]
        public void GetNumbersFrom1To1000ThatDivisibleByGivenNumber_WhenValidNumberPassed_ShouldReturnArray(
            int number, int[] expected)
        {
            int[] actual = Loops.GetNumbersFrom1To1000ThatDivisibleByGivenNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-100)]
        [TestCase(0)]
        [TestCase(1001)]
        [TestCase(1100)]
        public void GetNumbersFrom1To1000ThatDivisibleByGivenNumber_WhenNumberNotBelongsToTheRange_ShouldThrowArgumentOutOfRangeException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Loops.GetNumbersFrom1To1000ThatDivisibleByGivenNumber(number));
        }

        [TestCase(-10, 0)]
        [TestCase(0, 0)]
        [TestCase(4, 1)]
        [TestCase(100, 9)]
        [TestCase(101, 10)]
        public void GetQuantityOfPositiveWholeNumbers_WhenValidNumberPassed_ShouldReturnCounter(
            int number, int expected)
        {
            int actual = Loops.GetQuantityOfPositiveWholeNumbers(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(100, 50)]
        [TestCase(121, 11)]
        [TestCase(625, 125)]
        public void GetGreatestDivisor_WhenValidNumberPassed_ShouldReturnGreatestDivisor(
            int number, int expected)
        {
            int actual = Loops.GetGreatestDivisor(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3, 3, 0)]
        [TestCase(-7, 0, -7)]
        [TestCase(0, 7, 7)]
        [TestCase(120, 10, 0)]
        [TestCase(-100, 300, 5586)]
        public void GetSumOfAllNumbersInTheRangeFromAToB_WhenValidNumberPassed_ShouldReturnSum(
            int a, int b, int expected)
        {
            int actual = Loops.GetSumOfAllNumbersInTheRangeFromAToB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(7, 13)]
        [TestCase(41, 165580141)]
        public void GetNthNumberOfTheFibonacciSeries_WhenValidNumberPassed_ShouldReturnFibonacciMember(
            int number, int expected)
        {
            int actual = Loops.GetNthNumberOfTheFibonacciSeries(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void GetNthNumberOfTheFibonacciSeries_WhenNumberLessThenOne_ShouldThrowArgumentException(
            int number)
        {
            Assert.Throws<ArgumentException>(() => Loops.GetNthNumberOfTheFibonacciSeries(number));
        }

        [TestCase(16, 52, 4)]
        [TestCase(22, 77, 11)]
        [TestCase(20, 50, 10)]
        public void GetResultOfEuclideanAlgorithm_WhenValidNumberPassed_ShouldReturnGreatestCommonFactor(
            int a, int b, int expected)
        {
            int actual = Loops.GetResultOfEuclideanAlgorithm(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-65, -1)]
        [TestCase(-64, -4)]
        [TestCase(-63, -1)]
        [TestCase(8, 2)]
        [TestCase(1, 1)]
        [TestCase(7, -1)]
        [TestCase(8, 2)]
        [TestCase(9, -1)]
        [TestCase(125, 5)]
        [TestCase(2146689000, 1290)]
        public void GetResultOfBinarySearchForCubicRoot_WhenValidNumberPassed_ShouldReturnRoot(
            int value, int expected)
        {
            int actual = Loops.GetResultOfBinarySearchForCubicRoot(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(-64, 0)]
        [TestCase(-63, 1)]
        [TestCase(8, 0)]
        [TestCase(7, 1)]
        [TestCase(125, 2)]
        [TestCase(2146689000, 2)]
        public void GetCounterOfOddDigits_WhenValidNumberPassed_ShouldReturnCounter(
            int value, int expected)
        {
            int actual = Loops.GetCounterOfOddDigits(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-123456, -654321)]
        [TestCase(-12345, -54321)]
        [TestCase(0, 0)]
        [TestCase(123456, 654321)]
        [TestCase(12345, 54321)]
        public void GetMirrorNumber_WhenValidNumberPassed_ShouldReturnMirrorNumber(
            int value, int expected)
        {
            int actual = Loops.GetMirrorNumber(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { })]
        [TestCase(16, new int[] { 2, 4, 6, 8, 12, 14, 16 })]
        [TestCase(49, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38, 40, 41, 42, 43, 44, 46, 48 })]
        public void GetArrayOfNumbersInRange_WhenValidNumberPassed_ShouldReturnArray(
            int number, int[] expected)
        {
            int[] actual = Loops.GetArrayOfNumbersInRange(number);

            Assert.AreEqual(expected, actual);
        }

        //How should I call this method?
        [TestCase(-5, 12345, true)]
        [TestCase(213, -2, true)]
        [TestCase(0, 0, true)]
        [TestCase(50, 729, false)]
        [TestCase(-329467, -8, false)]
        public void IsContainEqualDigits_WhenValidNumberPassed_ShouldReturnBool(
            int a, int b, bool expected)
        {
            bool actual = Loops.IsContainEqualDigits(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
