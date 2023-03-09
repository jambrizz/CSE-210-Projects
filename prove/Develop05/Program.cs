using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool programRun = true;
        do
        {
            //Goal goal = new Goal(0);
            Console.WriteLine($"You have X points");
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
                //TODO Create a loop to handle user no selecting a valid choice
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                int goalSelection = Convert.ToInt32(goalType);
                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\n {goalSelection}, {goalName}, {goalDescription}, {goalPoints}\n");
                //Simple simple = new Simple(goalName, goalDescription, goalPoints);
                if (goalSelection == 1)
                {
                    Simple simple = new Simple(goalName, goalDescription, goalPoints);
                }
                else if (goalSelection == 2)
                {
                    Eternal eternal = new Eternal(goalName, goalDescription, goalPoints);
                }
                else if (goalSelection == 3)
                {
                    Checklist checklist = new Checklist(goalName, goalDescription, goalPoints);
                }
                else
                {
                    Console.WriteLine("You did not select a valid choice please try again");
                }
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