using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public List<string> tents = new List<string>{"Name: Coleman 4 person tent, ProductId: clm8921, Price: 199.99"};
    public string [,] sleepingBags = {{"Name: Redcamp 20 degree sleeping bag", "ProductId: rdc8924", "Price: 89.99"}, {"Name: Coleman 30 degree sleeping bag", "ProductId: clm8925", "Price: 99.99"}, {"Name: Ozark 40 degree sleeping bag", "ProductId: ozk8926", "Price: 109.99"}};
    public string [,] cookware = {{"Name: Stanley Adventure 2 quart cook set", "ProductId: stn8927", "Price: 49.99"}, {"Name: Coleman 4 quart cook set", "ProductId: clm8928", "Price: 59.99"}, {"Name: Ozark 6 quart cook set", "ProductId: ozk8929", "Price: 69.99"}};
    public string [,] lanterns = {{"Name: Coleman 2D lantern", "ProductId: clm8930", "Price: 29.99"}, {"Name: Coleman 4D lantern", "ProductId: clm8931", "Price: 39.99"}, {"Name: Ozark 6D lantern", "ProductId: ozk8932", "Price: 49.99"}};

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public Product()
    {

    }

    public string GetProduct()
    {
        return _productName;
    }

    public void SetProduct(string productName)
    {
        _productName = productName;
    }


    public string GetProductId()
    {
        return _productId;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }


    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }


    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public void DisplayProducts(List<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }

}