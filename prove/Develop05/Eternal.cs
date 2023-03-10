using System;
using System.Collections.Generic;

public class Eternal : Goal
{
    //private string _GoalItem;

    //private int points;

    private bool status;

    public Eternal(string goal, string description, int score) : base(goal, description, score)
    {
        status = false;
        _goalItem = goal;
        _score = score;
        _goalDescription = description;
    }

    public override int CalculateScore()
    {
        return 0;
    }

    public override string RecordGoal()
    {
        return $"[ ] {_goalItem} ({_goalDescription}): {_score} points";
    }
    
    public override bool IsComplete()
    {
        return status;
    }

    public override string NewGoal()
    {
        return "";
    }
}