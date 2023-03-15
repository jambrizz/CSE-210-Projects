using System;
using System.Collections.Generic;

public class Eternal : Goal
{

    //private bool status;

    public Eternal(bool status, string goal, string description, int score, string goaltype) : base(status, goal, description, score, goaltype)
    {
        _status = status;
        _goalItem = goal;
        _score = score;
        _goalDescription = description;
        _goalType = goaltype;
    }

    public override int CalculateScore()
    {
        return 0;
    }

    //TODO Change this to add details about the object ex. "Score: 10" to use this to access certain parts of the string in the txt file
    public override string RecordGoal()
    {
        return $"{_goalType}:[ ] {_goalItem} ({_goalDescription}), {_score},{_status}";
    }
    
    /*
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