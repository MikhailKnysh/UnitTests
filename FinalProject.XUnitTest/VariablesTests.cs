using System;
using Xunit;

namespace FinalProject.XUnitTest
{
    public class VariablesTests
    {
        [Theory]
        [InlineData(-121, 0, -5)]
        [InlineData(2, 13, 16.273)]
        [InlineData(3.9, 1.2, -7.756)]
        [InlineData(517.289, 246.371, -233.595)]
        public void Formula_WhenValidABPassed_ShouldCalculateEquation(double a, double b, double excepted)
        {
            double actual = Variables.Formula(a, b);

            Assert.Equal(excepted, actual);
        }

        [Fact]
        public void Formula_WhenAEqualB_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Variables.Formula(19, 19));
        }

        [Theory]
        [InlineData(146, -15, -15, 146)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-121, 0, 0, -121)]
        [InlineData(-2, -13, -13, -2)]
        [InlineData(int.MaxValue, 1001, 1001, int.MaxValue)]
        [InlineData(-1315, int.MinValue, int.MinValue, -1315)]
        public void Swap_WhenValidABPassed_ShouldSwapValues(ref int a, ref int b, int expectedA, int expectedB)
        {
            Variables.Swap(ref a, ref b);

            int actualA = a;
            int actualB = b;

            Assert.Equal(expectedA, actualA);
            Assert.Equal(expectedB, actualB);
        }

        [Theory]
        [InlineData(17, 3, 5, 2)]
        [InlineData(10357, 2222, 4, 1469)]
        [InlineData(0, 12, 0, 0)]
        [InlineData(int.MaxValue, -105371, -20380, 22667)]
        [InlineData(-596, 33, -18, -2)]
        public void DivisionAndRemainder_WhenValidABPassed_ShouldCalculateDivisionAndRemainder(int a, int b, int exceptedDivision, int exceptedRemainder)
        {
            int[] actual = Variables.DivisionAndRemainder(a, b);

            Assert.Equal(exceptedDivision, actual[0]);
            Assert.Equal(exceptedRemainder, actual[1]);
        }

        [Fact]
        public void DivisionAndRemainder_WhenBEqualZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Variables.DivisionAndRemainder(19, 0));
        }

        [Theory]
        [InlineData(8, 3, 14, 1.375)]
        [InlineData(3.51244, 9375.876, -28.46, -2677.437)]
        [InlineData(3, 0, 0, 0)]
        [InlineData(0.0015341, 1.203865, 1.19005, -9.005)]
        public void Equation_WhenValidABCPassed_ShouldCalculateEquation(double a, double b, double c, double excepted)
        {
            double actual = Variables.Equation(a, b, c);

            Assert.Equal(excepted, actual);
        }

        [Fact]
        public void Equation_WhenAEqualZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Variables.Equation(0, 2, 15));
        }

        [Theory]
        [InlineData(8, 0, 14, 0, 0, 0)]
        [InlineData(5, 9, 16, 3, -0.545, 11.727)]
        [InlineData(9.475, 3.512, -12.65, -1045, 47.39, -445.512)]
        [InlineData(-11.1, -9.35, 15.4, 14.05, 0.883, 0.452)]
        public void StraightLineEquation_WhenValidX1X2Y1Y2Passed_ShouldCalculateEquation(double x1, double y1, double x2, double y2, double exceptedA, double exceptedB)
        {
            double[] actual = Variables.StraightLineEquation(x1, y1, x2, y2);

            Assert.Equal(exceptedA, actual[0]);
            Assert.Equal(exceptedB, actual[1]);
        }

        [Fact]
        public void StraightLineEquation_WhenX1EqualX2_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Variables.StraightLineEquation(0, 2, 0, 15));
        }
    }
}