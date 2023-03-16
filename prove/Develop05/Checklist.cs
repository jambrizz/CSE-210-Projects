using System;
using System.Collections.Generic;

public class Checklist : Goal
{
     private int points;

     private int timesCompleted;

     private int overallCount;

     public Checklist(bool status, string goal, string description, int score, string goaltype, int completed, int overall, int bonus) : base(status, goal, description, score, goaltype, completed, overall, bonus)
     {
        _status = status;
        _goalItem = goal;
        _score = score;
        _goalDescription = description;
        _goalType = goaltype;
        _completed = completed;
        _overall = overall;
        _bonus = bonus;
     }

    // todo fix the method below

    //TODO Change this to add details about the object ex. "Score: 10" to use this to access certain parts of the string in the txt file
    public override string RecordGoal()
    {
        return $"{_goalType}:[ ] Name:{_goalItem} Description:({_goalDescription}), Score:{_score}, Bonus:{_bonus}, Denominator:{_overall}, Numerator:{_completed}, Status:{_status}";
    }
     public override int CalculateScore()
     {
         return points;
     }
    /*
     public override string RecordEvent()
     {
         return _GoalItem;
     }
    
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