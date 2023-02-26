using System;

public class Assignment
{
    protected string _studentName;

    protected string _topic;

    public string GetSummary()
    {
        return $"Student name: {_studentName} Topic: {_topic}";
    }
}