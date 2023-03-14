using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string>();
        bool programRun = true;
        do
        {
            //List<string> goals = new List<string>();
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
                Console.Clear();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                int goalSelectionType = Convert.ToInt32(goalType);
                
                if(goalSelectionType == 1)
                {
                    Console.Clear();
                    bool status = false;
                    string goaltype = "Simple";
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = Convert.ToInt32(Console.ReadLine());
                    
                    Simple simple = new Simple(status, goalName, goalDescription, goalPoints, goaltype);
                    goals.Add(simple.RecordGoal());
                    Console.Clear(); 
                }
                else if(goalSelectionType == 2)
                {
                    Console.Clear();
                    bool status = false;
                    string goaltype = "Eternal";
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = Convert.ToInt32(Console.ReadLine());
                    
                    Eternal eternal = new Eternal(status, goalName, goalDescription, goalPoints, goaltype);
                    goals.Add(eternal.RecordGoal());
                    Console.Clear();
                }
                //TODO fix the checklist goal
                else if(goalSelectionType == 3)
                {
                    Console.Clear();
                    bool status = false;
                    string goaltype = "Checklist";
                    int completed = 0;
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = Convert.ToInt32(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int overall = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing your goal that many times? ");
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    
                    Checklist checklist = new Checklist(status, goalName, goalDescription, goalPoints, goaltype, completed, overall, bonus);
                    goals.Add(checklist.RecordGoal());
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n You did not select a valid choice please try again \n");
                }
            }
            else if(selection == 2)
            {
                //TODO need to fix this to only display the goals that are loaded or pending to save also add a feature to make sure the goal list is empty for the next time the program is run
                foreach (var item in goals)
                {
                    Console.Write(goals.IndexOf(item) + 1 + ". ");
                    Console.Write(item + "\n");
                };
                Console.WriteLine("\n"); 
            }
            else if(selection == 3)
            {
                Console.Write("What is the filename for the goal file (don't forget to add .txt of your filename)? ");
                string fileName = Console.ReadLine();
                Options options = new Options(fileName, goals);
                goals.Clear();
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