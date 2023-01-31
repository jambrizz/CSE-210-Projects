using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        do
        {
            Console.WriteLine("Welcome to your Journal Program");
        Console.WriteLine("Please select a feature from the menu below:");
        Console.WriteLine("Display: 1");
        Console.WriteLine("Write: 2");
        Console.WriteLine("Load: 3");
        Console.WriteLine("Save: 4");
        Console.WriteLine("Quit: 5");
        Console.WriteLine("Enter a number for what you would like to do: ");
        string userSelection = Console.ReadLine();
         
        if (userSelection == "5")
        {
            x ++;
        }
           
        if (userSelection == "1" || userSelection == "2" || userSelection == "3" || userSelection == "4" || userSelection == "5")
        {
            int feature = Convert.ToInt32(userSelection);
            Journal journal = new Journal();
            journal.FeatureSelection(feature);
        }
        else
        {
            Console.WriteLine("Please enter a valid number from 1-5");
        }

        }
        while (x == 0);
    }
}