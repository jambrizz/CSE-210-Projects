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
        List<string> orderHistory = new List<string>();
        bool programRun = true;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Camping WholeSale Supply!");
            Console.WriteLine("We have the best camping gear at the best prices!");
            Console.WriteLine("Site Navigation");
            Console.WriteLine("1. Browse Products");
            Console.WriteLine("2. View Cart");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("4. Packing label");
            Console.WriteLine("5. Shipping label");
            Console.WriteLine("6. Order History");
            Console.WriteLine("7. Exit");
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
                
                //////////////////// Browse Products ////////////////////
                if(featureSelection == 1)
                {
                    Console.Clear();
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
                //////////////////// Shopping Cart ////////////////////
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
                        /////////////////////////////////////////////
                        //If I have enough time I would like to add a method to the Cart class to change the quantity of an item in the cart.
                        /////////////////////////////////////////////
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
                ////////////////////   Checkout  ////////////////////
                else if (featureSelection == 3)
                {
                    if(cart.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Checkout: \n");
                        Console.WriteLine();
                        Console.WriteLine("Your cart is empty. \n");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Checkout: \n");
                        Console.WriteLine();
                        Console.WriteLine("Your cart contains the following items: \n");
                        Console.WriteLine();
                        Cart shoppingCart = new Cart();
                        shoppingCart.DisplayCart(cart);

                        double subtotal = shoppingCart.GetSubtotal(cart);

                        Console.WriteLine();
                        Console.WriteLine($"Subtotal: {subtotal}");

                        Console.WriteLine();
                        Console.Write("Would you like to proceed to checkout? (Y/N): ");
                        string continueToCheckout = Console.ReadLine();

                        if(continueToCheckout == "y" || continueToCheckout == "Y")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Customer Info. \n");
                            Console.WriteLine();
                            Console.Write("Enter your first name: ");
                            string firstName = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter your last name: ");
                            string lastName = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter your email address: ");
                            string email = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter your phone number(no dashes or paranthesis): ");
                            string phoneNumber = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Shipping Info. \n");
                            Console.WriteLine();
                            Console.Write("Enter your street address: ");
                            string streetAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter your city: ");
                            string city = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter your state/province: ");
                            string state = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter your zip/postal code: ");
                            string zipCode = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter your country: ");
                            string country = Console.ReadLine();

                            Customer customerInfo = new Customer(firstName, lastName, email, phoneNumber);

                            Shipping shippingInfo = new Shipping(streetAddress, city, state, zipCode, country);

                            string customerDet = customerInfo.ConfirmCustomerInfo();
                            string shippingDet = shippingInfo.ConfirmShippingDetails();
                            Console.WriteLine();
                            Console.WriteLine(customerDet);
                            Console.WriteLine();
                            Console.WriteLine(shippingDet);
                            Console.WriteLine();

                            Console.Write("Is you information correct? (Y/N): ");
                            string confirmInfo = Console.ReadLine();

                            if(confirmInfo == "y" || confirmInfo == "Y")
                            {
                                customer.Add($"Customer: {customerInfo.GetCustomerInfo()} {shippingInfo.GetShippingAddress()} \n");

                                if(country == "united states of america" || country == "United States of America" || country == "USA" || country == "usa" || country == "U.S.A." || country == "u.s.a." || country == "US" || country == "us" || country =="U.S." || country == "u.s.")
                                {
                                    bool shipping = true;
                                    double shippingFee = shoppingCart.GetShippingFee(shipping);
                                    double total = shoppingCart.GetTotal(subtotal, shippingFee);
                                    Console.WriteLine($"Subtotal: {subtotal}");
                                    Console.WriteLine($"Shipping fee: {shippingFee}");
                                    Console.WriteLine($"------------------------");
                                    Console.WriteLine($"Total: {total}");
                                    /////////////////////////////////////////////
                                    //TODO: This is where I left off.
                                    /////////////////////////////////////////////
                                }
                                else
                                {
                                    bool shipping = false;
                                    double shippingFee = shoppingCart.GetShippingFee(shipping);
                                    double total = shoppingCart.GetTotal(subtotal, shippingFee);
                                    Console.WriteLine($"Subtotal: {subtotal}");
                                    Console.WriteLine($"Shipping fee: {shippingFee}");
                                    Console.WriteLine($"------------------------");
                                    Console.WriteLine($"Total: {total}");
                                    /////////////////////////////////////////////
                                    //TODO: This is where I left off.
                                    /////////////////////////////////////////////
                                }
                                
                            }
                            else if(confirmInfo == "n" || confirmInfo == "N")
                            {
                                /////////////////////////////////////////////
                                //TODO: This is where I left off.
                                /////////////////////////////////////////////
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("You have entered an invalid selection. \n");
                            }
                           
                        }
                        else if(continueToCheckout == "n" || continueToCheckout == "N")
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have chosen not to proceed to checkout. \n");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have entered an invalid selection. \n");
                        }
                    }
                }
                ////////////////////   Packing label  ////////////////////
                else if (featureSelection == 4)
                {
                    
                }
                ////////////////////   Shipping label  ////////////////////
                else if (featureSelection == 5)
                {
                    
                }
                ////////////////////   order history  ////////////////////
                else if (featureSelection == 6)
                {

                }
                ////////////////////   Exit  ////////////////////
                else if (featureSelection == 7)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using Camping WholeSale Supply order system. \n");
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