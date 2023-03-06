using System;
using System.Collections.Generic;

public class Checklist : Goal
{
    private string GoalItem;

     private int points;

     private int bonus;

     private bool status;

     private int timesCompleted;

     private int overallCount;

     public Checklist(int score) : base(score)
     {
         status = false;
     }

    // todo fix the method below
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
         return status;
     }

    public override string NewGoal()
    {
        return "";
    }
}