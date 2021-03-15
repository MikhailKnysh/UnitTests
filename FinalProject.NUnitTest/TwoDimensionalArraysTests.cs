using FinalProjectLibrary;
using NUnit.Framework;
using System;

namespace FinalProject.NUnitTest
{
    class TwoDimensionalArraysTests
    {
        [TestCase(5)]
        [TestCase(6)]
        public void AllMethods_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(
            int mockNumber)
        {
            int[,] matrix = TwoDimArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() =>
            {
                TwoDimensionalArrays.FindMinElementOfTheTwoDimArray(matrix);
                TwoDimensionalArrays.FindMaxElementOfTheTwoDimArray(matrix);
                TwoDimensionalArrays.FindIndexOfMinElementOfTheTwoDimArray(matrix);
                TwoDimensionalArrays.FindIndexOfMaxElementOfTheTwoDimArray(matrix);
                TwoDimensionalArrays.TransposeMatrix(matrix);
            });
        }

        [TestCase(1, -545)]
        [TestCase(2, -545)]
        [TestCase(3, -434)]
        [TestCase(4, -17)]
        public void FindMinElementOfTheTwoDimArray_WhenValidArrayPassed_ShouldReturnMinElement(
            int mockNumber, int expected)
        {
            int[,] mockArr = TwoDimArrayMock.GetMock(mockNumber);

            int actual = TwoDimensionalArrays.FindMinElementOfTheTwoDimArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 67889)]
        [TestCase(2, 768)]
        [TestCase(3, 3534)]
        [TestCase(4, 11553)]
        public void FindMaxElementOfTheTwoDimArray_WhenValidArrayPassed_ShouldReturnMaxElement(
            int mockNumber, int expected)
        {
            int[,] mockArr = TwoDimArrayMock.GetMock(mockNumber);

            int actual = TwoDimensionalArrays.FindMaxElementOfTheTwoDimArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 0, 4 })]
        [TestCase(2, new int[] { 0, 4 })]
        [TestCase(3, new int[] { 1, 0 })]
        [TestCase(4, new int[] { 1, 1 })]
        public void FindIndexOfMinElementOfTheTwoDimArray_WhenValidArrayPassed_ShouldReturnIndexOfTheMaxElement(
            int mockNumber, int[] expected)
        {
            int[,] mockArr = TwoDimArrayMock.GetMock(mockNumber);

            int[] actual = TwoDimensionalArrays.FindIndexOfMinElementOfTheTwoDimArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 3, 3 })]
        [TestCase(2, new int[] { 0, 2 })]
        [TestCase(3, new int[] { 2, 0 })]
        [TestCase(4, new int[] { 1, 2 })]
        public void FindIndexOfMaxElementOfTheTwoDimArray_WhenValidArrayPassed_ShouldReturnIndexOfTheMaxElement(
            int mockNumber, int[] expected)
        {
            int[,] mockArr = TwoDimArrayMock.GetMock(mockNumber);

            int[] actual = TwoDimensionalArrays.FindIndexOfMaxElementOfTheTwoDimArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 1)]
        [TestCase(3, 3)]
        [TestCase(4, 2)]
        [TestCase(5, 0)]
        public void GetCounterOfAllSmallestNeighbours_WhenValidArrayPassed_ShouldReturnCounter(
            int mockNumber, int expected)
        {
            int[,] mockArr = TwoDimArrayMock.GetMock(mockNumber);

            int actual = TwoDimensionalArrays.GetCounterOfAllSmallestNeighbours(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 7)]
        [TestCase(2, 8)]
        [TestCase(3, 9)]
        [TestCase(4, 10)]
        public void TransposeMatrix_WhenValidArrayPassed_ShouldReturnTransposedMatrix(
            int mockNumberActual, int mockNumberExpected)
        {
            int[,] mockArr = TwoDimArrayMock.GetMock(mockNumberActual);
            int[,] mockArrActual = TwoDimensionalArrays.TransposeMatrix(mockArr);
            int[,] mockArrExpected = TwoDimArrayMock.GetMock(mockNumberExpected);

            Assert.AreEqual(mockArrExpected, mockArrActual);
        }
    }

    public static class TwoDimArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];

            switch (number)
            {
                case 1:
                    result = new int[5, 5]
                    {
                        { 12, 565, 768, 56, -545 },
                        { -434, -46, 563, 232, 64 },
                        { 3534, 797, 12, 46, 34 },
                        { 4, 5, 234, 67889, 24 },
                        { 667, -424, 24, 231, 13 }
                    };
                    break;
                case 2:
                    result = new int[1, 5]
                    {
                        { 12, 565, 768, 56, -545 }
                    };
                    break;
                case 3:
                    result = new int[5, 1]
                    {
                        { 12 },
                        { -434 },
                        { 3534 },
                        { 4 },
                        { 667 }
                    };
                    break;
                case 4:
                    result = new int[2, 3]
                    {
                        { 355, 242, 2442 },
                        { 13, -17, 11553 }
                    };
                    break;
                case 5:
                    result = new int[0, 0];
                    break;
                case 6:
                    result = null;
                    break;
                case 7:
                    result = new int[5, 5]
                    {
                        { 12, -434, 3534, 4, 667 },
                        { 565, -46, 797, 5, -424 },
                        { 768, 563, 12, 234, 24 },
                        { 56, 232, 46, 67889, 231 },
                        { -545, 64, 34, 24, 13 }
                    };
                    break;
                case 8:
                    result = new int[5, 1]
                    {
                        { 12 },
                        { 565 },
                        { 768 },
                        { 56 },
                        { -545 }
                    };
                    break;
                case 9:
                    result = new int[1, 5]
                    {
                        { 12, -434, 3534, 4, 667 }
                    };
                    
                    break;
                case 10:
                    result = new int[3, 2]
                    {
                        { 355, 13 },
                        { 242, -17 },
                        { 2442, 11553 },
                    };
                    break;
            }

            return result;
        }
    }
}
