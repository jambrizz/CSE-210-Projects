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

    //TODO test this method
    public override string RecordGoal()
    {
        return $"{_goalType}:[ ] {_goalItem} ({_goalDescription}), {_score},{_status}";
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