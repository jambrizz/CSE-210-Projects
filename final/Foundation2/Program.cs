using System;

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
                        Console.WriteLine();
                        Console.WriteLine("Tents");
                        Product product = new Product();
                        ////////////////////////////////////////////////////
                        //TODO: fix the line of code below
                        ////////////////////////////////////////////////////
                        string productDetails = product.DisplayProducts(tents);
                    }
                    else if(productSelectionInt == 2)
                    {

                    }
                    else if(productSelectionInt == 3)
                    {

                    }
                    else if(productSelectionInt == 4)
                    {

                    }
                    else if(productSelectionInt == 5)
                    {

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid selection. \n");
                    }

                }
                else if (featureSelection == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have selected to view your cart. \n");
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