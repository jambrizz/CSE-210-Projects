using System;
using System.Collections.Generic;

public class Simple : Goal
{
    private string _GoalItem;

    private int points;

    private bool status;

    public Simple(int score) : base(score)
    {
        status = false;
    }

    public override int CalculateScore()
    {
        return points;
    }

    public override string RecordEvent()
    {
        return GoalItem;
    }

    // todo fix the method below
    public override bool IsComplete()
    {
        return status;
    }

    public override string NewGoal()
    {
        return "";
    }
}