using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Shipping
{
    private string _streetAddress;

    private string _city;

    private string _state;

    private string _zip;

    private string _country;

    public Shipping(string streetAddress, string city, string state, string zip, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public string ConfirmShippingDetails()
    {
        return $"\n Address: {_streetAddress} \n City: {_city} \n State: {_state} \n Zip: {_zip} \n Country: {_country}";
    }

    public string GetShippingAddress()
    {
        return $"Address: {_streetAddress}, City: {_city}, State: {_state}, Zip: {_zip}, Country: {_country},";
    }

    public string GetCountry()
    {
        return $"{_country}";
    }
}