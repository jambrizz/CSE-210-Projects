using System;
using System.Collections.Generic;

public abstract class Goal 
{
    protected int _score = 0;

    protected string _goalItem;

    protected string _goalDescription;

    //public List<string> goals = new List<string>();

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

    public Goal(int score)
    {
        _score = score;
    }
     public Goal()
     {

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
    public virtual string RecordGoal()
    {
        return "";
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public abstract string NewGoal();


}