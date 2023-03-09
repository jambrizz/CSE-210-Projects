using System;
using System.Collections.Generic;

public abstract class Goal 
{
    protected int _score;

    protected string _goalItem;

    protected string _goalDescription;

    protected List<string> goals = new List<string>();

    public object GetGoalsList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        return list;
    }

    public Goal(string goalItem, string description, int score)
    {
        _goalItem = goalItem;
        _goalDescription = description;
        _score = score;
    }
    
    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public virtual int CalculateScore()
    {
        return 0;
    }

    //TODO test this method
    public virtual string RecordEvent()
    {
        return "";
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public void SetListGoals(string GoalItem)
    {
        goals.Add(GoalItem);
    }

    public abstract string NewGoal();


}