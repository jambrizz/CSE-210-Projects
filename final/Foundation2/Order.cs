using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Order
{
    private string _customerInfo;

    private string _shippingInfo;

    private List<string> _list;

    private double _total;

    private string _orderNumber;

    private string _orderDate;

    /////////////////////////////////////////////
    //TODO: This is where I left off.
    /////////////////////////////////////////////

    public Order(string customerInfo, string shippingInfo, List<string> list, double total)
    {
        _customerInfo = customerInfo;
        _shippingInfo = shippingInfo;
        _list = list;
        _total = total;
        _orderNumber = GetOrderNumber();
        _orderDate = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public int RandomNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 1000);
        return randomNumber;
    }

    public char RandomLetter()
    {
        Random random = new Random();
        char randomLetter = (char)random.Next('a', 'z');
        return randomLetter;
    }

    public string GetOrderNumber()
    {
        string orderNo = "";
        for (int i = 0; i < 3; i++)
        {
            orderNo += RandomLetter();
            orderNo += RandomNumber();
        }
        return orderNo;
    }
    
    public string PlaceOrder()
    {   
        string order = "";

        foreach (string item in _list)
        {
           order += item + " "; 
        }

        return $"Order No: {_orderNumber}, Customer info: {_customerInfo} {_shippingInfo} Order Details: {order}, Order Date: {_orderDate} Order Total: {_total}";
    }
}