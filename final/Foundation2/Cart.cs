using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Cart
{
   private string _product;

   private int _quantity; 

   public Cart(string product, int quantity)
   {
       _product = product;
       _quantity = quantity;
   }

   public Cart()
   {

   }

   public string ItemToAddToCart()
   {
       return $"{_product}, Quantity: {_quantity}";
   }

   public void DisplayCart(List<string> list)
   {    
        int i = 1;
         foreach (string item in list)
         {
            Console.WriteLine(i + ". " + item);
            i++;
         }
   }

   public double GetSubtotal(List<string> list)
   {
        double total = 0;
        foreach (string item in list)
        {
            string newLine = item;
            string [] seperator = {","};
            string [] removePartsOfString = {"Price:", "Quantity:", " "};

            int positionOfPrice = newLine.IndexOf("Price:");
            string price = newLine.Substring(positionOfPrice);

            int positionOfQuantity = newLine.IndexOf("Quantity:");
            string quantity = newLine.Substring(positionOfQuantity);

            string [] priceArray = price.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            string [] quantityArray = quantity.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

            string priceArrayString = priceArray[0];
            string quantityArrayString = quantityArray[0];

            foreach (string line in removePartsOfString)
            {
                priceArrayString = priceArrayString.Replace(line, "");
            }

            foreach (string line in removePartsOfString)
            {
                quantityArrayString = quantityArrayString.Replace(line, "");
            }
            
            double priceDouble = Convert.ToDouble(priceArrayString);
            int quantityInt = Convert.ToInt32(quantityArrayString);

            double subtotal = priceDouble * quantityInt;
            
            total += subtotal;
        }
        return total;
   }

   public double GetShippingFee (bool shipping)
   {
        if(shipping == true)
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
   }

   public double GetTotal(double subtotal, double shipping)
   {
        double total = subtotal + shipping;
        return total;
   }
}