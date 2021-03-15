using NUnit.Framework;
using System;

namespace FinalProject.NUnitTest
{
    class OneDimensionalArraysTests
    {
        [TestCase(1, -1422)]
        [TestCase(2, -1523)]
        [TestCase(3, -1794)]
        [TestCase(4, -294298)]
        public void FindMinElementOfTheArray_WhenValidArrayPassed_ShouldReturnMinElement(int mockNumber, int expected)
        {
            int[] mockArr = OneDimArrayMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.FindMinElementOfTheArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void FindMinElementOfTheArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.FindMinElementOfTheArray(arr));
        }

        [TestCase(1, 1947)]
        [TestCase(2, 2174)]
        [TestCase(3, 2055)]
        [TestCase(4, 842962)]
        public void FindMaxElementOfTheArray_WhenValidArrayPassed_ShouldReturnMaxElement(int mockNumber, int expected)
        {
            int[] mockArr = OneDimArrayMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.FindMaxElementOfTheArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void FindMaxElementOfTheArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.FindMaxElementOfTheArray(arr));
        }

        [TestCase(1, 8)]
        [TestCase(2, 15)]
        [TestCase(3, 6)]
        [TestCase(4, 23)]
        public void FindIndexOfMinElementOfTheArray_WhenValidArrayPassed_ShouldReturnIndexOfMinElement(int mockNumber, int expected)
        {
            int[] mockArr = OneDimArrayMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.FindIndexOfMinElementOfTheArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void FindIndexOfMinElementOfTheArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.FindIndexOfMinElementOfTheArray(arr));
        }

        [TestCase(1, 6)]
        [TestCase(2, 10)]
        [TestCase(3, 0)]
        [TestCase(4, 33)]
        public void FindIndexOfMaxElementOfTheArray_WhenValidArrayPassed_ShouldReturnIndexOfMaxElement(int mockNumber, int expected)
        {
            int[] mockArr = OneDimArrayMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.FindIndexOfMaxElementOfTheArray(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void FindIndexOfMaxElementOfTheArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.FindIndexOfMaxElementOfTheArray(arr));
        }

        [TestCase(1, 359)]
        [TestCase(2, 1749)]
        [TestCase(3, 10319)]
        [TestCase(4, 3750733)]
        public void GetSumOfArrayElementsWithOddIndexes_WhenValidArrayPassed_ShouldReturnSum(int mockNumber, int expected)
        {
            int[] mockArr = OneDimArrayMock.GetMock(mockNumber);

            int actual = OneDimensionalArrays.GetSumOfArrayElementsWithOddIndexes(mockArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void GetSumOfArrayElementsWithOddIndexes_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.GetSumOfArrayElementsWithOddIndexes(arr));
        }

        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 11, 2, 3, 4, -5, 6, 7, -8 }, new int[] { -8, 7, 6, -5, 4, 3, 2, 11 })]
        public void ReverseArray_WhenValidArrayPassed_ShouldReturnReversedArray(int[] input, int[] expected)
        {
            int[] actual = OneDimensionalArrays.ReverseArray(input);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void ReverseArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.ReverseArray(arr));
        }

        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 2 }, 1)]
        [TestCase(new int[] { 11, 2, 3, 4, -5, 6, 7, -8 }, 4)]
        public void GetCountOddElementsOfTheArray_WhenValidArrayPassed_ShouldReturnCounter(
        int[] input, int expected)
        {
            int actual = OneDimensionalArrays.GetCountOddElementsOfTheArray(input);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void GetCountOddElementsOfTheArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.GetCountOddElementsOfTheArray(arr));
        }

        
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { -1, 2, 3, -4, 5 }, new int[] { -4, 5, 3, -1, 2 })]
        public void SwapHalves_WhenValidArrayPassed_ShouldReturnSwappedArray(
            int[] input, int[] expected)
        {
            int[] actual = OneDimensionalArrays.SwapHalves(input);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void SwapHalves_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.SwapHalves(arr));
        }

        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 3, 1, -2 }, new int[] { -2, 1, 2, 3 })]
        [TestCase(new int[] { 11, 2, 3, 4, -5, 6, 7, -8 }, new int[] { -8, -5, 2, 3, 4, 6, 7, 11 })]
        public void BubbleSort_WhenValidArrayPassed_ShouldReturnSortedArrayInAscendingOrder(int[] input, int[] expected)
        {
            int[] actual = OneDimensionalArrays.BubbleSort(input);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void BubbleSort_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.BubbleSort(arr));
        }

        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 3, 1, -2 }, new int[] { 3, 2, 1, -2 })]
        [TestCase(new int[] { 11, 2, 3, 4, -5, 6, 7, -8 }, new int[] { 11, 7, 6, 4, 3, 2, -5, -8 })]
        public void SelectionSort_WhenValidArrayPassed_ShouldReturnSortedArrayInDescendingOrder(int[] input, int[] expected)
        {
            int[] actual = OneDimensionalArrays.SelectionSort(input);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0])]
        public void SelectionSort_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
                OneDimensionalArrays.SelectionSort(arr));
        }
    }
}
