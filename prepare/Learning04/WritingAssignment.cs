using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingIinformation()
    {
        return $"Title: {_title}";
    }
}