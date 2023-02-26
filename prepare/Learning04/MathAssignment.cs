using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;

    public string GetHomeworkList()
    {
        return $"Textbook section: {_textbookSection} Problems: {_problems}";
    }
}