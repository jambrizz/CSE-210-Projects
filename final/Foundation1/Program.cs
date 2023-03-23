using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> comments = new List<string>();
        List<string> videos = new List<string>();
        
        bool programRun = true;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Youtube Product Tracking");
            Console.WriteLine("Welcome to the Youtube Product Tracking Program");
            Console.WriteLine("Please select an option from the menu below:");
            Console.WriteLine("1. Add a video");
            Console.WriteLine("2. Add a comment");
            Console.WriteLine("3. Display all videos");
            Console.WriteLine("4. Display video details");
            Console.WriteLine("5. Save videos to file");
            Console.WriteLine("6. Load videos from file");
            Console.WriteLine("7. Exit program");
            Console.Write("Please enter your selection:");
            string userSelection = Console.ReadLine();
            bool validSelection = int.TryParse(userSelection, out int selection);

            if(validSelection == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid selection. Please try again. \n");
            }
            else
            {
                int featureSelection = int.Parse(userSelection);
                if(featureSelection == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have selected to add a video. \n");
                }
                else if(featureSelection == 2)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to add a comment. \n");
                }
                else if(featureSelection == 3)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to display all videos. \n");
                }
                else if(featureSelection == 4)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to display video details. \n");
                }
                else if(featureSelection == 5)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to save videos to file. \n");
                }
                else if(featureSelection == 6)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to load videos from file. \n");
                }
                else if(featureSelection == 7)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"Thank you for using the Youtube Product Tracking App. See you next time. \n");
                    programRun = false;
                }
                else
                {
                    Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                }
                
            }
        }
        while (programRun == true);
    }
}