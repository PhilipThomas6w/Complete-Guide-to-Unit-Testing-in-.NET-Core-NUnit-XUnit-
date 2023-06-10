using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CalculatorNUnitTests
{
    [Test]
    public void AddNumbers_InputTwoIntegers_GetCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.AddNumbers(10, 20);

        // Assert
        Assert.AreEqual(30, result);

    }

    [TestCase(3, true)]
    [TestCase(2, false)]
    public void IsOddNumber_InputInteger_GetTrueIfOddOrFalseIfEven(int input, bool expectedResult)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        bool result = calculator.IsOddNumber(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    
}