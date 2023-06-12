using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CustomerNUnitTests
{
    private Customer? _customer;
    
    [SetUp]
    public void SetUp()
    {
        _customer = new Customer();
    }


    [Test]
    public void GivenFirstNameAndLastName_GetFullName_ReturnsFullName()
    {
        // Arrange
        // We instantiate a Customer object in SetUp...
        var firstName = "Philip";
        var lastName = "Thomas";


        // Act
        var fullName = _customer!.GetFullName(firstName, lastName);


        // Assert
        Assert.That(fullName, Is.EqualTo("Philip Thomas"));

        
        // Helper Methods
        Assert.That(fullName, Does.Contain("Philip"));
        Assert.That(fullName, Does.StartWith("P"));
        Assert.That(fullName, Does.EndWith("s"));

    }

    [Test]
    public void TestMethod()
    {
        // Arrange
        // We instantiate a Customer object in SetUp...



        // Act



        // Assert
        Assert.That(_customer!.Greeting, Is.Null);
        
    }

    [Test]
    public void GivenOrderTotal_GetCustomerDetails_ReturnsCustomerType()
    {
        // Arrange
        // We instantiate a Customer object in SetUp...
        
        _customer!.OrderTotal = 80;

        // Act
        var result = _customer.GetCustomerDetails();


        // Assert
        Assert.That(result, Is.TypeOf<BronzeCustomer>());
    }

    [TestCase(80, typeof(BronzeCustomer))]
    [TestCase(123, typeof(SilverCustomer))]
    [TestCase(245, typeof(GoldCustomer))]
    [TestCase(452, typeof(PlatinumCustomer))]
    public void GivenOrderTotal_GetCustomerDetails_ReturnsCustomerType(int orderTotal, Type expectedType)
    {
        // Arrange
        // We instantiate a Customer object in SetUp...

        _customer!.OrderTotal = orderTotal;

        // Act
        var result = _customer.GetCustomerDetails();


        // Assert
        Assert.That(result, Is.TypeOf(expectedType));
    }

}