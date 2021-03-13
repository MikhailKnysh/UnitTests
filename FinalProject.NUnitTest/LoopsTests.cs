using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace FinalProject.NUnitTest
{
    public class IntArrayTestDataSource : IEnumerable
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            int[] arrayStep1 = new int[1000];
            int size = 0;

            for (int i = 0; i < arrayStep1.Length; i++)
            {
                arrayStep1[size++] = i + 1;
            }

            int[] arrayStep3 = new int[1000 / 3];
            size = 0;

            for (int i = 3; i < arrayStep3.Length; i += 3)
            {
                arrayStep3[size++] = i;
            }

            int[] arrayStep5 = new int[1000 / 5];
            size = 0;

            for (int i = 5; i < arrayStep5.Length; i += 5)
            {
                arrayStep5[size++] = i;
            }

            int[] arrayStep13 = new int[1000 / 13];
            size = 0;

            for (int i = 13; i < arrayStep13.Length; i += 13)
            {
                arrayStep13[size++] = i;
            }

            int[] arrayStep165 = new int[1000 / 165];
            size = 0;

            for (int i = 165; i < arrayStep165.Length; i += 165)
            {
                arrayStep165[size++] = i;
            }

            yield return new object[] { 1, arrayStep1 };
            yield return new object[] { 3, arrayStep3 };
            yield return new object[] { 5, arrayStep5 };
            yield return new object[] { 13, arrayStep13 };
            yield return new object[] { 165, arrayStep165 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LoopsTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(99, 0, 1)]
        [TestCase(2, 10, 1024)]
        [TestCase(1290, 3, 2146689000)]
        [TestCase(-5, 3, -125)]
        [TestCase(-16, 2, 256)]
        public static void GetResultAfterComparison_WhenValidABPassed_ShouldReturnResultAfterComparison(
            int number, int power, int expected)
        {
            double actual = Loops.GetPow(number, power);

            Assert.AreEqual(expected, actual);
        }

        //[TestCaseSource(typeof(IntArrayTestDataSource))]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(333, new int[] { 333, 666, 999 })]
        [TestCase(125, new int[] { 125, 250, 375, 500, 625, 750, 875, 1000 })]
        public static void GetNumbersFrom1To1000ThatDivisibleByGivenNumber_WhenValidNumberPassed_ShouldReturnArray(
            int number, int[] expected)
        {
            int[] actual = Loops.GetNumbersFrom1To1000ThatDivisibleByGivenNumber(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
