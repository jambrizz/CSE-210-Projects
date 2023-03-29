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
}