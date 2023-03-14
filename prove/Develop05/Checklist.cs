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

    public override string RecordGoal()
    {
        return $"{_goalType}:[ ] {_goalItem} ({_goalDescription}), {_score}, {_bonus}, {_overall}, {_completed}, {_status}";
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