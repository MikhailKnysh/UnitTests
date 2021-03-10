using System;
using Xunit;

namespace FinalProject.XUnitTest
{
    public class VariablesTests
    {
        [Theory]
        [InlineData(3.9, 1.2, -7.756)]
        [InlineData(3.9, 1.3, -7.756)]
        public void Formula_WhenValidABPassed_ShouldCalculateEquation(double a, double b, double excepted)
        {
            double actual = Variables.Formula(a, b);

            Assert.Equal(excepted, actual);
        }

        public void Formula_WhenAEqualB_ShouldThrowDivideByZeroException(double a, double b)
        {

        }
    }
}