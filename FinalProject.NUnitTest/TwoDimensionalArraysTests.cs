using FinalProjectLibrary;
using NUnit.Framework;
using System;

namespace FinalProject.NUnitTest
{
    class TwoDimensionalArraysTests
    {
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

        [TestCase(5)]
        [TestCase(6)]
        public void FindMinElementOfTheTwoDimArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(
            int mockNumber)
        {
            int[,] matrix = TwoDimArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() =>
                TwoDimensionalArrays.FindMinElementOfTheTwoDimArray(matrix));
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

        [TestCase(5)]
        [TestCase(6)]
        public void FindMaxElementOfTheTwoDimArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(
            int mockNumber)
        {
            int[,] matrix = TwoDimArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() =>
                TwoDimensionalArrays.FindMaxElementOfTheTwoDimArray(matrix));
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

        [TestCase(5)]
        [TestCase(6)]
        public void FindIndexOfMinElementOfTheTwoDimArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(
            int mockNumber)
        {
            int[,] matrix = TwoDimArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() =>
                TwoDimensionalArrays.FindIndexOfMinElementOfTheTwoDimArray(matrix));
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

        [TestCase(5)]
        [TestCase(6)]
        public void FindIndexOfMaxElementOfTheTwoDimArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(
            int mockNumber)
        {
            int[,] matrix = TwoDimArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() =>
                TwoDimensionalArrays.FindIndexOfMaxElementOfTheTwoDimArray(matrix));
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

        [TestCase(6)]
        public void GetCounterOfAllSmallestNeighbours_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(
            int mockNumber)
        {
            int[,] matrix = TwoDimArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() =>
                TwoDimensionalArrays.GetCounterOfAllSmallestNeighbours(matrix));
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

        [TestCase(5)]
        [TestCase(6)]
        public void AllMethods_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(
            int mockNumber)
        {
            int[,] matrix = TwoDimArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() =>
                TwoDimensionalArrays.TransposeMatrix(matrix));
        }
    }
}
