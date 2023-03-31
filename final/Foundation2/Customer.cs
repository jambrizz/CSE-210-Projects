using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Customer
{
    private string _firstName;

    private string _lastName;

    private string _email;

    private string _phone;

    public Customer(string firstName, string lastName, string email, string phone)
    {
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _phone = phone;
    }

    public string ConfirmCustomerInfo()
    {
        return $"\n FirstName: {_firstName} \n LastName: {_lastName} \n Email: {_email} \n Phone: {_phone}";
    }

    public string GetCustomerInfo()
    {
        return $"FirstName: {_firstName}, LastName: {_lastName}, Email: {_email}, Phone: {_phone},";
    }
}