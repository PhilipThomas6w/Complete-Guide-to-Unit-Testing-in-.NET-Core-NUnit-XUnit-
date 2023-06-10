namespace Sparky
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoIntegers_GetCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.AddNumbers(10, 20);

            // Assert
            Assert.AreEqual(30, result);

        }

        [TestMethod]
        public void IsOddNumber_InputOddInteger_GetTrue()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            bool result = calculator.IsOddNumber(3);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsOddNumber_InputEvenInteger_GetFalse()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            bool result = calculator.IsOddNumber(2);

            // Assert
            Assert.AreEqual(false, result);
        }

    }
}
