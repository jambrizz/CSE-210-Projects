using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string>();
        bool programRun = true;
        do
        {
            if(goals.Count > 0)
            {
                string startingTotal = goals[0];
                string [] removePartsOfString = {"TotalScore:"};
                string [] numberAsString = startingTotal.Split(removePartsOfString, StringSplitOptions.RemoveEmptyEntries);
                bool isNumber = int.TryParse(numberAsString[0], out int startingTotalNumber);
                if (isNumber == true)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have {startingTotalNumber} points");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You have 0 points");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You have 0 points");
            }
            
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
                    Console.WriteLine();
                    Console.WriteLine("You did not select a valid choice please try again \n");
                }
            }
            else if(selection == 2)
            {
                if (goals.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have no goals to display, Please load a file or create a goal \n");
                }
                else
                {
                    Console.Clear();
                    string startingTotal = goals[0];
                    string [] removePartsOfString = {"TotalScore:"};
                    string [] numberAsString = startingTotal.Split(removePartsOfString, StringSplitOptions.RemoveEmptyEntries);
                    bool isNumber = int.TryParse(numberAsString[0], out int startingTotalNumber);
                    if (isNumber == true)
                    {
                        Options options = new Options(goals);
                        options.DisplayGoalsFromTxt(goals);
                    }
                    else
                    {
                        Options options = new Options(goals);
                        options.DisplayGoalsFromList(goals);
                    }
                }
            }
            else if(selection == 3)
            {   
                Console.Clear();
                Console.Write("What is the filename for the goal file (don't forget to add .txt of your filename)? ");
                string fileName = Console.ReadLine();
                Options options = new Options(fileName, goals);
                options.SaveGoals(fileName, goals);
                goals.Clear();
            }
            else if(selection == 4)
            {
                Console.Clear();
                Console.Write("What is the filename for the goal file (don't forget to add .txt of your filename)? ");
                string fileName = Console.ReadLine();
                bool fileExists = System.IO.File.Exists(fileName);
                if(fileExists == true)
                {
                    Options options = new Options(fileName, goals);
                    options.LoadFile(fileName, goals);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("The file you are trying to load does not exist \n");
                }
            }
            else if(selection == 5)
            {
                
                if (goals.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have no goals to display, Please load a file or create a goal \n");
                }
                else
                {
                    Console.Clear();
                    string startingTotal = goals[0];
                    string [] removePartsOfString = {"TotalScore:"};
                    string [] numberAsString = startingTotal.Split(removePartsOfString, StringSplitOptions.RemoveEmptyEntries);
                    bool isNumber = int.TryParse(numberAsString[0], out int startingTotalNumber);
                    
                    if (isNumber == false)
                    {
                        Console.WriteLine("Please save your goals first before recording an event \n");
                    }
                    else
                    {
                        Console.Clear();
                        Options options = new Options(goals);
                        options.DisplayGoalsFromTxt(goals);
                        Console.WriteLine();
                        Console.Write("Please enter the number of the goal you would like to record progress on: ");
                        int itemSelected = Convert.ToInt32(Console.ReadLine());
                    
                        if(itemSelected > goals.Count)
                        {
                            Console.WriteLine("You did not select a valid choice \n");
                        }
                        else
                        {
                        
                            string lineItem = goals[itemSelected];
                            string type = lineItem.Substring(0, lineItem.IndexOf(":"));
                            bool isGoalCompleted = lineItem.Contains("Status:True");
                            if(isGoalCompleted == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine("This goal has already been completed. Please select a different goal to complete \n");
                            }
                            else
                            {
                                if(type == "Simple")
                                {
                                    Simple simple = new Simple(goals, lineItem);
                                    string updatedGoal = simple.RecordEvent(goals,lineItem);
                                    goals.RemoveAt(itemSelected);
                                    goals.Insert(itemSelected, updatedGoal);

                                    Simple simple2 = new Simple(goals, itemSelected);
                                    string updatedScoreTotal = simple2.CalculateScore(goals, itemSelected);
                                    goals.RemoveAt(0);
                                    goals.Insert(0, updatedScoreTotal);
                                }
                                else if(type == "Eternal")
                                {
                                    Eternal eternal = new Eternal(goals, itemSelected);
                                    string updatedScoreTotal = eternal.CalculateScore(goals, itemSelected);
                                    goals.RemoveAt(0);
                                    goals.Insert(0, updatedScoreTotal);
                                }
                                else if(type == "Checklist")
                                {
                                    Checklist checklist = new Checklist(goals, itemSelected);
                                    string updatedGoal = checklist.RecordEvent(goals, lineItem);
    
                                    goals.RemoveAt(itemSelected);
                                    goals.Insert(itemSelected, updatedGoal);
                            
                                    Checklist checklist2 = new Checklist(goals, itemSelected);
                                    string updatedScoreTotal = checklist2.CalculateScore(goals, itemSelected);
                                    goals.RemoveAt(0);
                                    goals.Insert(0, updatedScoreTotal);
                                }
                                else
                                {
                                    Console.WriteLine("You did not select a valid choice \n");
                                }
                            }
                        }
                    }
                    
                }
            }
            else if(selection == 6)
            {
                int isListEmpty = goals.Count;
                if(isListEmpty == 0)
                {
                    Console.WriteLine("Thank you for using the Eternal Quest Program! See you next time \n");
                    programRun = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have not saved your goals. If you exit now you will lose all progress. \n");
                    Console.Write("Are you sure you want to exit? (Y/N) ");
                    string exit = Console.ReadLine();
                    if(exit == "Y" || exit == "y")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using the Eternal Quest Program! See you next time. \n");
                        programRun = false;
                    }
                    else if(exit == "N" || exit == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Eternal Quest Program is still running. \n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You did not select a valid choice, the Eternal Quest program is still running. \n");
                    }
                }
            }
            else
            {
                Console.WriteLine("You did not select a valid choice");
            }
        }
        while (programRun == true);
    }

}