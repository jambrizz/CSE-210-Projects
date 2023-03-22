using System;
using System.Collections.Generic;

public class Simple : Goal
{    
    public Simple(bool status, string goal, string description, int score, string goaltype) : base(status, goal, description, score, goaltype)
    {
        _status = status;
        _goalItem = goal;
        _score = score;
        _goalDescription = description;
        _goalType = goaltype;
    }

    public Simple(List<string> list, string line) :base(list, line)
    {
        _list = list;
        _line = line;
    }

    public Simple(List<string> list, int number) :base(list, number)
    {
        _list = list;
        _number = number;
    }

    public override string NewGoal()
    {
        throw new NotImplementedException();
    }

    public override string RecordGoal()
    {
        return $"{_goalType}:[ ], Name:{_goalItem} Description:({_goalDescription}), Score:{_score}, Status:{_status}";
    }

    public override string RecordEvent(List<string> list, string line)
    {
        string newLine = line;
        
        int position1 = newLine.IndexOf(']') - 1;
        

        newLine = newLine.Remove(position1, 1);
        newLine = newLine.Insert(position1, "X");
        newLine = newLine.Replace("Status:False", "Status:True");
        return newLine;
    }

    public override string CalculateScore(List<string> list, int number)
    {
        string startingTotal = list[0];
        string newLine = list[number];

        string [] removePartsOfString = {"TotalScore:", " "};
        string [] exposePartsOfString = {"Score:"};
        string [] seperator = {","};

        int positionOfScore = newLine.IndexOf("Score:");
        string score = newLine.Substring(positionOfScore);

        string [] scoreArray = score.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        string scoreString = scoreArray[0];

        foreach (string item in removePartsOfString)
        {
            startingTotal = startingTotal.Replace(item, "");
        }

        foreach (string item in exposePartsOfString)
        {
            scoreString = scoreString.Replace(item, "");
        }

        int startingTotalInt = Convert.ToInt32(startingTotal);
        int scoreInt = Convert.ToInt32(scoreString);

        int newTotalScore = startingTotalInt + scoreInt;
        newTotalScore.ToString();
        string newTotalScoreString = $"TotalScore:{newTotalScore}";
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You completed a goal! You have earned {scoreInt} points! Your new total score is {newTotalScore}! \n");
        
        return newTotalScoreString;
    }
}