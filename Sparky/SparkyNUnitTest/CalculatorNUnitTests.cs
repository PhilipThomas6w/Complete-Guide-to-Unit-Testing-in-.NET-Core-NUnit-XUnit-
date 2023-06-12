using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CalculatorNUnitTests
{
    private Calculator? _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void AddNumbers_InputTwoIntegers_GetCorrectSum()
    {
        // Arrange
        // new Calculator object is instantiated in SetUp

        // Act
        int result = _calculator!.AddNumbers(10, 20);

        // Assert
        Assert.AreEqual(30, result);

    }

    [TestCase(3, true)]
    [TestCase(2, false)]
    public void IsOddNumber_InputInteger_GetTrueIfOddOrFalseIfEven(int input, bool expectedResult)
    {
        // Arrange
        // new Calculator object is instantiated in SetUp

        // Act
        bool result = _calculator!.IsOddNumber(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void GivenMinValueAndMaxValue_GetOddNumbersWithinRange_ReturnsListOfOddNumbersWithinRange()
    {
        // Arrange
        // new Calculator object is instantiated in SetUp
        var expectedResult = new List<int> { 1, 3, 5, 7, 9, 11 };

        // Act
        var result = _calculator!.GetOddNumbersWithinRange(1, 12);

        // Assert
        Assert.That(result, Is.EquivalentTo(expectedResult));  // use EquivalentTo method when comparing collections...
    }





}