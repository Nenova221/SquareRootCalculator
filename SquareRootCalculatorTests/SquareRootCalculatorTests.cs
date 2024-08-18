using SquareRootCalculator;
using Xunit;

namespace SquareRootCalculatorTests
{
    public class SquareRootCalculatorTests
    {
        [Theory]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(16, 4)]
        public void Calculate_WithCalculateSquareRoot_ShouldReturnCorrectResult(double input, double expected)
        {
            double result = SquareRootCalculator.Calculate(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Calculate_NegativeInput_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SquareRootCalculator.Calculate(-1));
        }
    }
}