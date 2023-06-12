using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky;

public class Customer
{
    public string? Greeting { get; set; }
    public int OrderTotal { get; set; }

    public string GetFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }

    public string Greet(string firstName, string lastName)
    {
        Greeting = $"Hello, {firstName} {lastName}";
        return Greeting;
    }

    public CustomerType GetCustomerDetails()
    {
        switch (OrderTotal)
        {
            case > 300:
                return new PlatinumCustomer();
                break;
            case > 200:
                return new GoldCustomer();
                break;
            case > 100:
                return new SilverCustomer();
                break;
            default:
                return new BronzeCustomer();
                break;
        }
    }

}

public class CustomerType {}

public class BronzeCustomer : CustomerType { }
public class SilverCustomer : CustomerType { }
public class GoldCustomer : CustomerType { }
public class PlatinumCustomer : CustomerType { }

