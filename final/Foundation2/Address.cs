using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Address
{
    private string _address;

    private string _address2;

    private string _city;

    private string _state;

    private int _zip;

    public Address(string address, string address2, string city, string state, int zip)
    {
        _address = address;
        _address2 = address2;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public string GetShippingDetails()
    {
        return "Address: " + _address + "Address2: " + _address2 + "City: " + _city + "State: " + _state + "Zip: " + _zip;
    }

}