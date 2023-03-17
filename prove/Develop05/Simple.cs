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

    public override int CalculateScore()
    {
        return _score;
    }

    public override string NewGoal()
    {
        throw new NotImplementedException();
    }

    //TODO Change this to add details about the object ex. "Score: 10" to use this to access certain parts of the string in the txt file
    public override string RecordGoal()
    {
        return $"{_goalType}:[ ] Name:{_goalItem} Description:({_goalDescription}), Score:{_score}, Status:{_status}";
    }

    public override string RecordEvent(string line)
    {
        //TODO: work on creating a new line of string to add to the list
        return "";
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