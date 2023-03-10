using System;
using System.Collections.Generic;

public class Simple : Goal
{
    //private string _goalItem;

    //private int points;

    private bool status;

    public Simple(string goal, string description, int score) : base(goal, description, score)
    {
        //status = false;
        _goalItem = goal;
        _score = score;
        _goalDescription = description;
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
        //string goal = $"[ ] {_goalItem} ({_goalDescription}: {_score} points)";
        return $"[ ] {_goalItem} ({_goalDescription}): {_score} points";
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