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
        return $"{_goalType}:[ ], Name:{_goalItem} Description:({_goalDescription}) -- Completed: {_completed}/{_overall}, Score:{_score}, Bonus:{_bonus}, Denominator:{_overall}, Numerator:{_completed}, Status:{_status}";
    }
    
    public override string RecordEvent(List<string> list, string line)
    {
        string newLine = line;
        string [] exposePartsOfString = {"Denominator:", "Numerator:", "Status:", "Completed:", "Score:", "Bonus:"};
        string [] seperator = {","};
        string [] seperatorChar = {"/"};

        //This section of the code is to find the numerator, denominator, and status of the checklist goal
        int positionOfCompleted = newLine.IndexOf("Completed:", 1);
        string completed = newLine.Substring(positionOfCompleted);

        int positionOfScore = newLine.IndexOf("Score:");
        string score = newLine.Substring(positionOfScore);

        int positionOfBonus = newLine.IndexOf("Bonus:");
        string bonus = newLine.Substring(positionOfBonus);

        int positionOfNumerator = newLine.IndexOf("Numerator:");
        string numerator = newLine.Substring(positionOfNumerator);

        int positionOfDenominator = newLine.IndexOf("Denominator:");
        string denominator = newLine.Substring(positionOfDenominator);

        int positionOfStatus = newLine.IndexOf("Status:");
        string status = newLine.Substring(positionOfStatus);
        
        //This section of the code is to remove the words "Denominator:", "Numerator:", and "Status:" from the numerator, denominator, and status strings
        string [] completedArray1 = completed.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string [] completedArray2 = completedArray1[0].Split(seperatorChar, StringSplitOptions.RemoveEmptyEntries);
        string completedString = completedArray2[0];

        string[] scoreArray = score.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string scoreString = scoreArray[0];

        string[] bonusArray = bonus.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string bonusString = bonusArray[0];

        string [] numeratorArray = numerator.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string numeratorString = numeratorArray[0];

        string [] denominatorArray = denominator.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string denominatorString = denominatorArray[0];

        string [] statusArray = status.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string statusString = statusArray[0];

        foreach (string item in exposePartsOfString)
        {
            completedString = completedString.Replace(item, "");
        }

        foreach (string item in exposePartsOfString)
        {
            scoreString = scoreString.Replace(item, "");
        }

        foreach (string item in exposePartsOfString)
        {
            bonusString = bonusString.Replace(item, "");
        }

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
        int completedInt = Convert.ToInt32(completedString);
        int scoreInt = Convert.ToInt32(scoreString);
        int bonusInt = Convert.ToInt32(bonusString);
        int numeratorInt = Convert.ToInt32(numeratorString);
        int denominatorInt = Convert.ToInt32(denominatorString);
        bool statusBool = Convert.ToBoolean(statusString);

        //This section of the code is to do the calculations for the numerator and denominator
        
        bool isGoalCompleted = numeratorInt == denominatorInt;
        if (isGoalCompleted == false)
        {
            numeratorInt++;
            newLine = newLine.Remove(positionOfCompleted);
            newLine = newLine.Insert(positionOfCompleted, "Completed:" + numeratorInt + "/" + denominatorInt + ", " + "Score:" + scoreInt + ", " + "Bonus:" + bonusInt + ", " + "Denominator:" + denominatorInt + ", " + "Numerator:" + numeratorInt + ", " + "Status:" + statusBool);

            //This section of the code is to check if the goal is completed and if it is then it will change the status to true and add an X to the checkbox
            if (numeratorInt == denominatorInt)
            {
                newLine = newLine.Remove(positionOfStatus);
                newLine = newLine.Insert(positionOfStatus, "Status:True");
                newLine = newLine.Replace("[ ]", "[X]");
            }
            
            else
            {
                newLine = newLine.Remove(positionOfStatus);
                newLine = newLine.Insert(positionOfStatus, "Status:False");
            }
            
        }
        else
        {
            Console.WriteLine("You have already completed this goal");
        }     
        return newLine;
    }

    public override string CalculateScore(List<string> list, int number)
    {
        string startingTotal = list[0];
        string newLine = list[number];
        
        string [] removePartsOfString = {"TotalScore:", " "};
        string [] exposePartsOfString = {"Denominator:", "Numerator:", "Score:", "Bonus:"};
        string [] seperator = {","};
        

        //This section of the code is to start isolating the index of the numerator, denominator, score, and bonus.
        int positionOfNumerator = newLine.IndexOf("Numerator:");
        string numerator = newLine.Substring(positionOfNumerator);
        
        int positionOfDenominator = newLine.IndexOf("Denominator:");
        string denominator = newLine.Substring(positionOfDenominator);
        
        int positionOfScore = newLine.IndexOf("Score:");
        string score = newLine.Substring(positionOfScore);
        
        int positionOfBonus = newLine.IndexOf("Bonus:");
        string bonus = newLine.Substring(positionOfBonus);

        //This section of the code is to expose the numbers for the numerator, denominator, score, and bonus as a string to then turn them into int.
        string [] numeratorArray = numerator.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string numeratorString = numeratorArray[0];
        
        string [] denominatorArray = denominator.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string denominatorString = denominatorArray[0];
        
        string [] scoreArray = score.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string scoreString = scoreArray[0];
        
        string [] bonusArray = bonus.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string bonusString = bonusArray[0];

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
            scoreString = scoreString.Replace(item, "");
        }

        foreach (string item in exposePartsOfString)
        {
            bonusString = bonusString.Replace(item, "");
        }

        foreach(string item in removePartsOfString)
        {
            startingTotal = startingTotal.Replace(item, "");
        }
        
        //This section of the code is to convert the numerator, denominator, score, and bonus strings into integers.
        int numeratorInt = Convert.ToInt32(numeratorString);
        int denominatorInt = Convert.ToInt32(denominatorString);
        int scoreInt = Convert.ToInt32(scoreString);
        int bonusInt = Convert.ToInt32(bonusString);
        int startingTotalInt = Convert.ToInt32(startingTotal);

        //This section of the code if statements to determine if to add only the score or the score and the bonus to the total score.

        bool isGoalCompleted = numeratorInt == denominatorInt;
        if (isGoalCompleted == true)
        {
            int newTotal = startingTotalInt + scoreInt + bonusInt;
            Console.WriteLine($"\n Congratulations! You completed a goal! You have earned {scoreInt} points and a bonus of {bonusInt}! Your new total score is {newTotal}! \n");
            newTotal.ToString();
            string newTotalScore = "TotalScore:" + newTotal;
            return newTotalScore;
        }
        else
        {
            int newTotal = startingTotalInt + scoreInt;
            Console.WriteLine();
            Console.WriteLine($"Congratulations! You completed a goal! You have earned {scoreInt} points! Your new total score is {newTotal}! \n");
            newTotal.ToString();
            string newTotalScore = "TotalScore:" + newTotal;
            return newTotalScore;
        }
    }
    
    public override string NewGoal()
    {
        return "";
    }
}