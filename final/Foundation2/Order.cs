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

    private double _subtotal;

    private double _shippingCost;

    private string _item;

    /////////////////////////////////////////////
    //TODO: This is where I left off.
    /////////////////////////////////////////////

    public Order(string customerInfo, string shippingInfo, List<string> list, double total, double subtotal, double shippingFee)
    {
        _customerInfo = customerInfo;
        _shippingInfo = shippingInfo;
        _list = list;
        _total = total;
        _subtotal = subtotal;
        _shippingCost = shippingFee;
        _orderNumber = GetOrderNumber();
        _orderDate = DateTime.Now.ToString("MM/dd/yyyy");
        _item = CartItems();
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
    
    public string CartItems()
    {
        string items = "";
        foreach (string item in _list)
        {
            items += item + " ";
        }

        return items;
    }

    public string PlaceOrder()
    {   
        return $"Order No: {_orderNumber}, Customer info: {_customerInfo} {_shippingInfo} Order Details: {_item} Order Date: {_orderDate}, Subtotal: {_subtotal}, ShippingFee: {_shippingCost}, Order Total: {_total},";
    }
}