using System;

class Program
{
    static void Main(string[] args)
    {
        bool programRun = true;
        do
        {
            Console.WriteLine("Welcome to the Eternal Quest Program!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List all goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Exit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            int selection = Convert.ToInt32(choice);

            if(selection == 1)
            {
                Console.WriteLine("\n Create a new goal \n");
            }
            else if(selection == 2)
            {
                Console.WriteLine("\n List all goals \n");
            }
            else if(selection == 3)
            {
                Console.WriteLine("\n Save goals \n");
            }
            else if(selection == 4)
            {
                Console.WriteLine("\n Load goals \n");
            }
            else if(selection == 5)
            {
                Console.WriteLine("\n Record event \n");
            }
            else if(selection == 6)
            {
                Console.WriteLine("\n Exit \n");
                programRun = false;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("You did not select a valid choice");
            }
        }
        while (programRun == true);
    }
}