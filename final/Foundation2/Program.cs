using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> cart = new List<string>();
        List<string> customer = new List<string>();
        bool programRun = true;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Camping Outlet!");
            Console.WriteLine("We have the best camping gear at the best prices!");
            Console.WriteLine("Site Navigation");
            Console.WriteLine("1. Browse Products");
            Console.WriteLine("2. View Cart");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter a number to navigate to the desired page: ");
            string userSelection = Console.ReadLine();
            bool isValidSelection = int.TryParse(userSelection, out int userSelectionInt);

            if (isValidSelection == false)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid selection. \n");
            }
            else
            {
                int featureSelection = int.Parse(userSelection);
                
                if(featureSelection == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Camping Outlet Products");
                    Console.WriteLine("1. Tents");
                    Console.WriteLine("2. Sleeping Bags");
                    Console.WriteLine("3. Cookware");
                    Console.WriteLine("4. Lanterns");
                    Console.WriteLine("5. Back to Site Navigation");
                    Console.Write("Please enter a number to navigate to the desired page: ");
                    string productSelection = Console.ReadLine();
                    bool isValidProductSelection = int.TryParse(productSelection, out int productSelectionInt);

                    if (isValidProductSelection == false)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid selection. \n");
                        Console.WriteLine();
                        Console.WriteLine("1. Tents");
                        Console.WriteLine("2. Sleeping Bags");
                        Console.WriteLine("3. Cookware");
                        Console.WriteLine("4. Lanterns");
                        Console.WriteLine("5. Back to Site Navigation");
                        Console.Write("Please enter a number to navigate to the desired page: ");
                        productSelection = Console.ReadLine();
                        isValidProductSelection = int.TryParse(productSelection, out productSelectionInt);
                    }

                    if (productSelectionInt == 1)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Tents");
                        Console.WriteLine();
                        Product product = new Product();
                        product.DisplayProducts(productSelectionInt);
                        Console.WriteLine();
                        Console.Write("Please enter the product number you would like to add to your cart: ");
                        string productNumber = Console.ReadLine();
                        bool isValidProductNumber = int.TryParse(productNumber, out int productNumberInt);

                        if (isValidProductNumber == false)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid selection. \n");
                            Console.WriteLine();
                            Console.WriteLine("Tents");
                            Console.WriteLine();
                            product.DisplayProducts(productSelectionInt);
                            Console.WriteLine();
                            Console.Write("Please enter the product number you would like to add to your cart: ");
                            productNumber = Console.ReadLine();
                            isValidProductNumber = int.TryParse(productNumber, out productNumberInt);
                        }

                        string selectedProduct = product.GetProductDetails("tents", productNumberInt);
                        Console.Clear();
                        Console.WriteLine(selectedProduct);
                        Console.WriteLine();
                        Console.Write("Would you like to add this product to your cart? (Y/N): ");
                        string addToCart = Console.ReadLine();

                        if(addToCart == "y" || addToCart == "Y")
                        {
                            Console.WriteLine();
                            Console.Write("Please enter the Quantity you wish to buy: ");
                            string quantityString = Console.ReadLine();
                            bool isValidQuantity = int.TryParse(quantityString, out int quantityInt);

                            if(isValidQuantity == false || quantityInt <= 0)
                            {
                               Console.WriteLine();
                               Console.WriteLine("You entered an invalid quantiry amount. \n");
                               Console.WriteLine();
                               Console.WriteLine("Please enter the Quantity you wish to buy: ");
                               quantityString = Console.ReadLine();
                               isValidQuantity = int.TryParse(quantityString, out quantityInt);
                            }
                            
                            Cart cartItem = new Cart(selectedProduct, quantityInt);
                            string item = cartItem.ItemToAddToCart();
                            cart.Add(item);
                            Console.WriteLine(item);
                            Console.WriteLine("Your item has been added to your cart. \n");
                        }
                        else if(addToCart == "n" || addToCart == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have chosen not to add this product to your cart. \n");
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid selection. \n");
                        }
                    }
                    else if(productSelectionInt == 2)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Sleeping Bags");
                        Console.WriteLine();
                        Product product = new Product();
                        //product.DisplaySleepingBags();
                        product.DisplayProducts(productSelectionInt);
                        Console.WriteLine();
                        Console.Write("Please enter the product number you would like to add to your cart: ");
                        string productNumber = Console.ReadLine();
                        bool isValidProductNumber = int.TryParse(productNumber, out int productNumberInt);

                        if (isValidProductNumber == false)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid selection. \n");
                            Console.WriteLine();
                            Console.WriteLine("Sleeping Bags");
                            Console.WriteLine();
                            product.DisplayProducts(productSelectionInt);
                            Console.WriteLine();
                            Console.Write("Please enter the product number you would like to add to your cart: ");
                            productNumber = Console.ReadLine();
                            isValidProductNumber = int.TryParse(productNumber, out productNumberInt);
                        }
                        string selectedProduct = product.GetProductDetails("sleepingBags", productNumberInt);
                        Console.WriteLine(selectedProduct);

                        Console.Clear();
                        Console.WriteLine(selectedProduct);
                        Console.WriteLine();
                        Console.Write("Would you like to add this product to your cart? (Y/N): ");
                        string addToCart = Console.ReadLine();

                        if(addToCart == "y" || addToCart == "Y")
                        {
                            Console.WriteLine();
                            Console.Write("Please enter the Quantity you wish to buy: ");
                            string quantityString = Console.ReadLine();
                            bool isValidQuantity = int.TryParse(quantityString, out int quantityInt); 

                            Cart cartItem = new Cart(selectedProduct, quantityInt);
                            string item = cartItem.ItemToAddToCart();
                            cart.Add(item);
                            Console.WriteLine(item);
                            Console.WriteLine("Your item has been added to your cart. \n");
                        }
                        else if(addToCart == "n" || addToCart == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have chosen not to add this product to your cart. \n");
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid selection. \n");
                        }
                    }
                    else if(productSelectionInt == 3)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Cookware");
                        Console.WriteLine();
                        Product product = new Product();
                        //product.DisplayCookware();
                        product.DisplayProducts(productSelectionInt);
                        Console.WriteLine();
                        Console.Write("Please enter the product number you would like to add to your cart: ");
                        string productNumber = Console.ReadLine();
                        bool isValidProductNumber = int.TryParse(productNumber, out int productNumberInt);

                        if (isValidProductNumber == false)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid selection. \n");
                            Console.WriteLine();
                            Console.WriteLine("Cookware");
                            Console.WriteLine();
                            product.DisplayProducts(productSelectionInt);
                            Console.WriteLine();
                            Console.Write("Please enter the product number you would like to add to your cart: ");
                            productNumber = Console.ReadLine();
                            isValidProductNumber = int.TryParse(productNumber, out productNumberInt);
                        }
                        
                        string selectedProduct = product.GetProductDetails("cookware", productNumberInt);
                        Console.WriteLine(selectedProduct);

                        Console.Clear();
                        Console.WriteLine(selectedProduct);
                        Console.WriteLine();
                        Console.Write("Would you like to add this product to your cart? (Y/N): ");
                        string addToCart = Console.ReadLine();

                        if(addToCart == "y" || addToCart == "Y")
                        {
                            Console.WriteLine();
                            Console.Write("Please enter the Quantity you wish to buy: ");
                            string quantityString = Console.ReadLine();
                            bool isValidQuantity = int.TryParse(quantityString, out int quantityInt);

                            if(isValidQuantity == false || quantityInt <= 0)
                            {
                               Console.WriteLine();
                               Console.WriteLine("You entered an invalid quantiry amount. \n");
                               Console.WriteLine();
                               Console.WriteLine("Please enter the Quantity you wish to buy: ");
                               quantityString = Console.ReadLine();
                               isValidQuantity = int.TryParse(quantityString, out quantityInt);
                            }
                            
                            Cart cartItem = new Cart(selectedProduct, quantityInt);
                            string item = cartItem.ItemToAddToCart();
                            cart.Add(item);
                            Console.WriteLine(item);
                            Console.WriteLine("Your item has been added to your cart. \n");
                        }
                        else if(addToCart == "n" || addToCart == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have chosen not to add this product to your cart. \n");
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid selection. \n");
                        }
                    }
                    else if(productSelectionInt == 4)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Lanterns");
                        Console.WriteLine();
                        Product product = new Product();
                        //product.DisplayLanterns();
                        product.DisplayProducts(productSelectionInt);
                        Console.WriteLine();
                        Console.Write("Please enter the product number you would like to add to your cart: ");
                        string productNumber = Console.ReadLine();
                        bool isValidProductNumber = int.TryParse(productNumber, out int productNumberInt);

                        if (isValidProductNumber == false)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid selection. \n");
                            Console.WriteLine();
                            Console.WriteLine("Lanterns");
                            Console.WriteLine();
                            product.DisplayProducts(productSelectionInt);
                            Console.WriteLine();
                            Console.Write("Please enter the product number you would like to add to your cart: ");
                            productNumber = Console.ReadLine();
                            isValidProductNumber = int.TryParse(productNumber, out productNumberInt);
                        }
                        
                        string selectedProduct = product.GetProductDetails("lanterns", productNumberInt);
                        //Console.WriteLine(selectedProduct);

                        Console.Clear();
                        Console.WriteLine(selectedProduct);
                        Console.WriteLine();
                        Console.Write("Would you like to add this product to your cart? (Y/N): ");
                        string addToCart = Console.ReadLine();

                        if(addToCart == "y" || addToCart == "Y")
                        {
                            Console.WriteLine();
                            Console.Write("Please enter the Quantity you wish to buy: ");
                            string quantityString = Console.ReadLine();
                            bool isValidQuantity = int.TryParse(quantityString, out int quantityInt);

                            if(isValidQuantity == false || quantityInt <= 0)
                            {
                               Console.WriteLine();
                               Console.WriteLine("You entered an invalid quantiry amount. \n");
                               Console.WriteLine();
                               Console.WriteLine("Please enter the Quantity you wish to buy: ");
                               quantityString = Console.ReadLine();
                               isValidQuantity = int.TryParse(quantityString, out quantityInt);
                            }
                            
                            Cart cartItem = new Cart(selectedProduct, quantityInt);
                            string item = cartItem.ItemToAddToCart();
                            cart.Add(item);
                            Console.WriteLine(item);
                            Console.WriteLine("Your item has been added to your cart. \n");
                        }
                        else if(addToCart == "n" || addToCart == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have chosen not to add this product to your cart. \n");
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid selection. \n");
                        }

                    }
                    else if(productSelectionInt == 5)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You have selected to return to the site navigation. \n");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid selection. \n");
                    }

                }
                else if (featureSelection == 2)
                {
                    if(cart.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Shopping Cart. \n");
                        Console.WriteLine();
                        Console.WriteLine("Your cart is empty. \n");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Shopping Cart. \n");
                        Console.WriteLine();
                        Console.WriteLine("Your cart contains the following items: \n");
                        Console.WriteLine();
                        Cart shoppingCart = new Cart();
                        shoppingCart.DisplayCart(cart);

                        Console.WriteLine();
                        Console.Write("Would you like to remove an item from your cart? (Y/N): ");
                        string removeItem = Console.ReadLine();

                        if(removeItem == "y" || removeItem == "Y")
                        {
                            Console.WriteLine();
                            Console.Write("Please enter the item number you would like to remove: ");
                            string itemNumber = Console.ReadLine();
                            bool isValidItemNumber = int.TryParse(itemNumber, out int itemNumberInt);

                            if(isValidItemNumber == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("You have entered an invalid item number. \n");
                                Console.WriteLine();
                                Console.Write("Please enter the item number you would like to remove: ");
                                itemNumber = Console.ReadLine();
                                isValidItemNumber = int.TryParse(itemNumber, out itemNumberInt);
                            }

                            int itemIndex = itemNumberInt - 1;
                            cart.RemoveAt(itemIndex);
                            Console.WriteLine("Your item has been removed from your cart. \n");
                        }
                        else if(removeItem == "n" || removeItem == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have chosen not to remove an item from your cart. \n");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have entered an invalid selection. \n");
                        }
                    }
                }
                else if (featureSelection == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have selected to checkout. \n");
                }
                else if (featureSelection == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for visiting Camping Outlet! See you next time. \n");
                    programRun = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid selection. \n");
                } 
            }
        }
        while (programRun == true);
    }
}