using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sparky;

public class GradingCalculatorNUnitTests
{
    private GradingCalculator? _gradingCalculator;

    [SetUp]
    public void SetUp()
    {
        _gradingCalculator = new GradingCalculator();
    }

    //[Test]
    //public void GivenScoreAndAttendance_GetGrade_ReturnsCorrectGrade()
    //{
    //    // Arrange
    //    // GradingCalculator object is instantiated during SetUp
    //    _gradingCalculator.Score = 95;
    //    _gradingCalculator.AttendancePercentage = 90;

    //    // Act
    //    var result = _gradingCalculator!.GetGrade();


    //    // Assert
    //    Assert.That(result, Is.EqualTo("A"));
    //}


    [TestCase(95, 90, "A")]
    [TestCase(85, 90, "B")]
    [TestCase(65, 90, "C")]
    [TestCase(95, 65, "B")]
    [TestCase(95, 55, "F")]
    [TestCase(65, 55, "F")]
    [TestCase(50, 90, "F")]
    public void GivenScoreAndAttendance_GetGrade_ReturnsCorrectGrade(int score, int attendancePercentage, string expectedResult)
    {
        // Arrange
        // GradingCalculator object is instantiated during SetUp
        _gradingCalculator!.Score = score;
        _gradingCalculator.AttendancePercentage = attendancePercentage;

        // Act
        var result = _gradingCalculator!.GetGrade();


        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }


}