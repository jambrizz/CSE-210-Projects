using System;
using System.Collections.Generic;

public abstract class Goal 
{
    protected int _score = 0;

    protected string _goalItem;

    protected string _goalDescription;

    protected string _goalType;

    protected bool _status;

    protected int _completed;

    protected int _overall;

    protected int _bonus;

    //public List<string> goals = new List<string>();

    public object GetGoalsList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        return list;
    }
    //This goal handles both simple and eternal goals
    public Goal(bool status, string goalItem, string description, int score, string goaltype)
    {
        _status = status;
        _goalItem = goalItem;
        _goalDescription = description;
        _score = score;
        _goalType = goaltype;
    }

    //This goal handles checklist goals
    public Goal(bool status, string goalItem, string description, int score, string goaltype, int completed, int overall, int bonus)
    {
        _status = status;
        _goalItem = goalItem;
        _goalDescription = description;
        _score = score;
        _goalType = goaltype;
        _completed = completed;
        _overall = overall;
        _bonus = bonus;

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