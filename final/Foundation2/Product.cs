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

    public List<string> tents = new List<string>{"Name: Coleman 4 person tent, ProductId: clm8921, Price: 199.99", "Name: Ozark 6 person tent, ProductId: ozk8922, Price: 299.99", "Name: Redcamp 8 person tent, ProductId: rdc8923, Price: 399.99"};

    public List<string> sleepingBags = new List<string>{"Name: Coleman 20 degree sleeping bag, ProductId: clm8924, Price: 130.99", "Name: Ozark 30 degree sleeping bag, ProductId: ozk8925, Price: 119.99", "Name: Redcamp 40 degree sleeping bag, ProductId: rdc8926, Price: 89.99"};

    public List<string> cookware = new List<string>{"Name: Coleman 4 quart cookware set, ProductId: clm8927, Price: 49.99", "Name: Ozark 6 quart cookware set, ProductId: ozk8928, Price: 59.99", "Name: Redcamp 8 quart cookware set, ProductId: rdc8929, Price: 69.99"};

    public List<string> lanterns = new List<string>{"Name: Coleman 700 Lumens lantern, ProductId: clm8930, Price: 29.99", "Name: Ozark 800 Lumens lantern, ProductId: ozk8931, Price: 39.99", "Name: Redcamp 1000 Lumens lantern, ProductId: rdc8932, Price: 49.99"};  

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

    public void DisplayProducts(int number)
    {
        if (number == 1)
        {
            int i = 1;
            foreach (string item in tents)
            {
                Console.WriteLine(i + ". " + item);
                i++;
            }
        }
        else if (number == 2)
        {
            int i = 1;
            foreach (string item in sleepingBags)
            {
                Console.WriteLine(i + ". " + item);
                i++;
            }
        }
        else if (number == 3)
        {   
            int i = 1;
            foreach (string item in cookware)
            {
                Console.WriteLine(i + ". " + item);
                i++;
            }
        }
        else if (number == 4)
        {
            int i = 1;
            foreach (string item in lanterns)
            {
                Console.WriteLine(i + ". " + item);
                i++;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    public string GetProductDetails(string product, int number)
    {
        if (product == "tents")
        {
            int i = number -1;
            return tents[i];
        }
        else if (product == "sleepingBags")
        {
            int i = number -1;
            return sleepingBags[i];
        }
        else if (product == "cookware")
        {
            int i = number -1;
            return cookware[i];
        }
        else if (product == "lanterns")
        {
            int i = number -1;
            return lanterns[i];
        }
        else
        {
            Console.WriteLine("You have entered an invalid product number.");
            return "";
        }
    }
}