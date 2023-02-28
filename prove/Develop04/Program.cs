using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        do
        {
            Console.WriteLine("Welcome to the Minfulness App!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit program");
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            int selection = Convert.ToInt32(userInput);

            if (selection == 1)
            {
                Console.WriteLine("You have selected the Breathing Activity \n");
            }
            else if (selection == 2)
            {
                Console.WriteLine("You have selected the Reflecting Activity \n");
            }
            else if (selection == 3)
            {
                Console.WriteLine("You have selected the Listing Activity \n");
            }
            else if (selection == 4)
            {
                Console.WriteLine("You have selected to quit the program \n");
                runProgram = false;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("You have selected an invalid option please try again \n");
            }
        }
        while(runProgram == true);
    }
}