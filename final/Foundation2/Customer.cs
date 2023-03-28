using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Customer
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public string GetCustomerName()
    {
        return "CustomerName: " + _name;
    }
}