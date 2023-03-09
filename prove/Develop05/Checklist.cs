using System;
using System.Collections.Generic;

public class Checklist : Goal
{
    private string _GoalItem;

     private int points;

     private int bonus;

     private bool status;

     private int timesCompleted;

     private int overallCount;

     public Checklist(string goal, string description, int score) : base(goal, description, score)
     {
        status = false;
        _GoalItem = goal;
        _score = score;
        _goalDescription = description;
     }

    // todo fix the method below
     public override int CalculateScore()
     {
         return points;
     }
    /*
     public override string RecordEvent()
     {
         return _GoalItem;
     }
    */
     public override bool IsComplete()
     {
         return status;
     }

    public override string NewGoal()
    {
        return "";
    }
}