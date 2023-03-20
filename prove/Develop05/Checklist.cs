using System;
using System.Collections.Generic;

public class Checklist : Goal
{
    private int points;

    private int timesCompleted;

    private int overallCount;

    public Checklist(bool status, string goal, string description, int score, string goaltype, int completed, int overall, int bonus) : base(status, goal, description, score, goaltype, completed, overall, bonus)
    {
       _status = status;
       _goalItem = goal;
       _score = score;
       _goalDescription = description;
       _goalType = goaltype;
       _completed = completed;
       _overall = overall;
       _bonus = bonus;
    }

    public Checklist(List<string> list, string line) :base(list, line)
    {
        _list = list;
        _line = line;
    }

    public Checklist(List<string> list, int number) :base(list, number)
    {
       _list = list;
       _number = number;
    }

    public override string RecordGoal()
    {
        return $"{_goalType}:[ ] Name:{_goalItem} Description:({_goalDescription}), Score:{_score}, Bonus:{_bonus}, Denominator:{_overall}, Numerator:{_completed}, Status:{_status}";
    }
    ///////////////////////////////////////////////////////////
    public override string RecordEvent(List<string> list, string line)
    {
        string newLine = line;
        string [] exposePartsOfString = {"Denominator:", "Numerator:", "Status:"};
        string [] seperator = {","};

        //This section of the code is to find the numerator, denominator, and status of the checklist goal
        int positionOfNumerator = newLine.IndexOf("Numerator:");
        string numerator = newLine.Substring(positionOfNumerator);
        int positionOfDenominator = newLine.IndexOf("Denominator:");
        string denominator = newLine.Substring(positionOfDenominator);
        int positionOfStatus = newLine.IndexOf("Status:");
        string status = newLine.Substring(positionOfStatus);
        
        //This section of the code is to remove the words "Denominator:", "Numerator:", and "Status:" from the numerator, denominator, and status strings
        string [] numeratorArray = numerator.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string numeratorString = numeratorArray[0];
        string [] denominatorArray = denominator.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string denominatorString = denominatorArray[0];
        string [] statusArray = status.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string statusString = statusArray[0];

        foreach (string item in exposePartsOfString)
        {
            numeratorString = numeratorString.Replace(item, "");
        }

        foreach (string item in exposePartsOfString)
        {
            denominatorString = denominatorString.Replace(item, "");
        }

        foreach (string item in exposePartsOfString)
        {
            statusString = statusString.Replace(item, "");
        }

        //This section of the code is to convert the numerator, denominator, and status strings into integers and booleans respectively
        int numeratorInt = Convert.ToInt32(numeratorString);
        int denominatorInt = Convert.ToInt32(denominatorString);
        bool statusBool = Convert.ToBoolean(statusString);

        Console.WriteLine("***********************************");
        Console.WriteLine(numeratorInt);
        Console.WriteLine(denominatorInt);
        Console.WriteLine(statusBool);
        Console.WriteLine("***********************************");

        ////////////////////////////////////////////////////////////
        /*
        if (x == true)
        {
            //int position1 = newLine.IndexOf(']') - 1;      
            //newLine = newLine.Remove(position1, 1);
            //newLine = newLine.Insert(position1, "X");
            //newLine = newLine.Replace("Status:False", "Status:True");
        }
        else
        {
            string [] removePartsOfString = {"Checklist:", "[ ]",};
        }
        */
        return newLine;
    }

    public override string CalculateScore(List<string> list, int number)
    {
        //TODO: Work on modifying this method to calculate the score for the checklist goal and add the bonus points if the goal is completed look at the method above for reference to get the syntax to extract the score and bonus points from the string
        string startingTotal = list[0];
        string scoreToAdd = list[number];
        
        string [] removePartsOfString = {"TotalScore:", " "};
        string [] removePartOfEntireString = {"A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z", ".", " ", ":", "(", ")", ",", "[X]", "[ ]", "[]", "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "_", "+", "|", "}", "{", "?", ">", "<", "`", "-", "=" };

        foreach (string item in removePartsOfString)
        {
            startingTotal = startingTotal.Replace(item, "");
        };

        foreach (string item in removePartOfEntireString)
        {
            scoreToAdd = scoreToAdd.Replace(item, "");
        };

        int newStartingTotal = Convert.ToInt32(startingTotal);
        int newScore = Convert.ToInt32(scoreToAdd);
        int newTotal = newStartingTotal + newScore;
        Console.WriteLine($"\n Congratulations! You completed a goal! You have earned {newScore} points! Your new total score is {newTotal}! \n");
        newTotal.ToString();
        string newTotalScore = $"TotalScore:{newTotal}";
        
        return newTotalScore;
    }
    ////////////////////////////////////////////////////////////
    /*
    public override string RecordEvent(string line)
    {
        //TODO: work on creating a new line of string to add to the list
        return "";
    }
    */
    /*
     public override int CalculateScore()
     {
         return points;
     }
    /*
     public override string RecordEvent()
     {
         return _GoalItem;
     }
    
     public override bool IsComplete()
     {
         return status;
     }
    */
    public override string NewGoal()
    {
        return "";
    }
}