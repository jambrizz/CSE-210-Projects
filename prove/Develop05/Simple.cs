using System;
using System.Collections.Generic;

public class Simple : Goal
{    
    //private bool status;

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
        return $"{_goalType}:[ ] Name:{_goalItem} Description:({_goalDescription}), Score:{_score}, Status:{_status}";
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
    /*
    // todo fix the method below
    public override bool IsComplete()
    {
        return status;
    }

    public override string NewGoal()
    {
        return "";
    }
    */
}