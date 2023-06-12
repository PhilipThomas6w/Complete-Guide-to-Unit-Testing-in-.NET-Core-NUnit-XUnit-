using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky;

public class GetFullNameNUnitTests
{
    [TestMethod]
    public void GivenFirstNameAndLastName_GetFullName_ReturnsFullName()
    {
        // Arrange
        var customer = new Customer();
        var firstName = "Philip";
        var lastName = "Thomas";


        // Act
        var fullName = customer.GetFullName(firstName, lastName);


        // Assert
        Assert.AreEqual("Philip Thomas", fullName);

    }

}