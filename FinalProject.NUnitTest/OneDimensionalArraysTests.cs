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

    public static class OneDimArrayMock
    {
        public static int[] GetMock(int number)
        {
            int[] result = new int[0];

            switch (number)
            {
                case 1:
                    result = new int[] { -795, 283, 113, 1841, 1233, 193, 1947, -534, -1422, -1424 };
                    break;
                case 2:
                    result = new int[] { 871, -138, -1010, 1038, -350, 155, -1330, -616, -711, -671, 2174, -786, -705, 1971, -424, -1523, -401, 288, 516, 2031 };
                    break;
                case 3:
                    result = new int[] { 2055, 1285, 1667, 471, -1350, -1547, -1794, 1870, 1605, 1618, 1149, 1084, 432, 416, 492, 1455, 1074, -581, 1694, 1393, 591, 1087, 233, -738, -674, 676, 2010, 214, 258, 1616 };
                    break;
                case 4:
                    result = new int[] { -205069, -182468, 496854, -72330, 705305, 364214, -182744, 179157, 159980, -223498, -222466, 493141, 25672, -113594, 497204, -146039, 608626, 21037, -149495, 472214, 346933, -45748, -256715, -294298, 814305, 103117, 642857, 748763, 269741, 308152, 315440, 90440, 449166, 842962, 810235, 648887, 500909, 439002, 188554, 117622 };
                    break;
            }

            return result;
        }
    }

}
