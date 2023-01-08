using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // This is to get the user's percentage grade and then display their letter grade
        Console.WriteLine("Lets get your letter grade");
        Console.WriteLine("What was your grade percentage?");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letterGrade = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        Console.WriteLine($"Your letter grade is {letterGrade}");

        // This is to display a message to the user based on their grade
        if (percentage >= 70)
        {
            Console.WriteLine("You passed the class, Congrats!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class this time around, better luck next time!");
        }
    }
}