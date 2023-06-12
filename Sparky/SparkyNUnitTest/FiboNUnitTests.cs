using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sparky;

public class FiboNUnitTests
{
    private Fibo? _fibo;

    [SetUp]

    public void SetUp()
    {
        _fibo = new Fibo();
    }

    [Test]
    public void GivenRangeOf1_GetFibonacciSeries_ReturnsListContaining0()
    {
        // Arrange
        _fibo.Range = 1;
        var expectedResult = new List<int> { 0 };

        // Act
        var result = _fibo.GetFibonacciSeries();


        // Assert
        Assert.That(result, Is.Ordered);
        Assert.That(result, Is.Not.Empty);
        Assert.That(result, Is.EquivalentTo(expectedResult));
    }

    [Test]
    public void GivenRangeOf6_GetFibonacciSeries_ReturnsListContaining0()
    {
        // Arrange
        _fibo.Range = 6;
        var expectedResult = new List<int> { 0, 1, 1, 2, 3, 5 };

        // Act
        var result = _fibo.GetFibonacciSeries();
        
        // Assert
        Assert.That(result, Does.Contain(3));
        Assert.That(result.Count, Is.EqualTo(6));
        Assert.That(result, Does.Not.Contain(4));
        Assert.That(result, Is.EquivalentTo(expectedResult));
    }



}