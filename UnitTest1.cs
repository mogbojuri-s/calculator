using Xunit;
using WinFormsApp5;
using WinFormsApp5.Tests.WinFormsApp5;

namespace WinFormsApp5.Tests
{
    public class CalculatorLogicTests
    {
        [Fact]
        public void SumIsValid()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();
            double expected = 5;

            // Act
            double actual = calculatorLogic.Sum(3, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractIsValid()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();
            double expected = 2;

            // Act
            double actual = calculatorLogic.Subtract(4, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplyIsValid()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();
            double expected = 8;

            // Act
            double actual = calculatorLogic.Multiply(4, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideIsValid()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();
            double expected = 2;

            // Act
            double actual = calculatorLogic.Divide(4, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideByZeroThrowsException()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculatorLogic.Divide(10, 0));
        }

        [Fact]
        public void SumWithNegativeNumbers()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();
            double expected = -3;

            // Act
            double actual = calculatorLogic.Sum(-5, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplyByZero()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();
            double expected = 0;

            // Act
            double actual = calculatorLogic.Multiply(10, 0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractWithEqualNumbers()
        {
            // Arrange
            var calculatorLogic = new CalculatorLogic();
            double expected = 0;

            // Act
            double actual = calculatorLogic.Subtract(5, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
