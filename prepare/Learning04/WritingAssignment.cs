using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }

    public void SetWritingAssignment(string title)
    {
        _title = title;
    }

    public string GetWritingAssignment()
    {
        return $"{GetSummary()}\n{GetWritingInformation()}  {GetStudentName()}\n";
    }
}