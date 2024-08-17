using SquareRootCalculator;

namespace SquareRootCalculatorTests
{
    public class SquareRootCalculatorTests
    {
        [Theory]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(16, 4)]
        public void CalculateSquareRoot_WithCalculateSquareRoot_ShouldReturnCorrectResult(double input, double expected)
        {
            double result = SquareRootCalculator.Calculate(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void CalculateSquareRoot_NegativeInput_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SquareRootCalculator.Calculate(-1));
        }
    }
}