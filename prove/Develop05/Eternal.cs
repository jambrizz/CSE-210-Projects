using System;
using System.Collections.Generic;

public class Eternal : Goal
{
    private string _GoalItem;

    private int points;

    private bool Status;

    public Eternal(int score) : base(score)
    {
        Status = false;
    }

    public override int CalculateScore()
    {
        return points;
    }

    public override string RecordEvent()
    {
        return GoalItem;
    }

    public override bool IsComplete()
    {
        return Status;
    }

    public override string NewGoal()
    {
        return "";
    }
}