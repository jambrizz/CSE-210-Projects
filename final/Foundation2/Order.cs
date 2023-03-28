using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Order
{
    private string _orderNumber;

    private string _customer;

    private string _orderDate;

    private string _productName;

    private string _productId;

    private double _price;

    private int _quantity;

    public Order(string orderNumber, string customer, string productName, string productId, double price, int quantity)
    {
        _orderNumber = orderNumber;
        _customer = customer;
        _orderDate = DateTime.Now.ToString("MM/dd/yyyy");
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetTotal()
    {
        double total = _price * _quantity;
        return "Total: " + total;
    }

    public string GetOrderDetails()
    {
        return "OrderNumber: " + _orderNumber + "Customer: " + _customer + "OrderDate: " + _orderDate + "ProductName: " + _productName + "ProductId: " + _productId + "Price: " + _price + "Quantity: " + _quantity;
    }
}