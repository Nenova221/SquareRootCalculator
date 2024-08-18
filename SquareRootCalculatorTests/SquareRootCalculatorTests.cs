using SquareRootCalculator;
using Xunit;

namespace SquareRootCalculatorTests
{
    public class SquareRootCalculatorTests
    {
        [Theory]
        [InlineData(12345, 111.1)]
        [InlineData(1552, 39.4)]
        [InlineData(753, 27.4)]
        public void Calculate_WithCalculateSquareRoot_ShouldReturnCorrectResult(double input, double expected)
        {
            double result = SquareRootCalculator.Calculate(input);
            Assert.Equal(expected, result, 1);
        }
        [Fact]
        public void Calculate_NegativeInput_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SquareRootCalculator.Calculate(-1));
        }
    }
}