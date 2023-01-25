using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal Program");
        Console.WriteLine("Please select a feature from the menu below:");
        Console.WriteLine("Display: 1");
        Console.WriteLine("Write: 2");
        Console.WriteLine("Load: 3");
        Console.WriteLine("Save: 4");
        Console.WriteLine("Quit: 5");
        Console.WriteLine("Enter a number for what you would like to do: ");
        int userSelection = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("You have selected: " + featureSelection);

        Journal journal = new Journal();
        journal._featureSelection = userSelection;
    }
}