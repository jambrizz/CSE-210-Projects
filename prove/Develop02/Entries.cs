using System;

public class Entries
{
    public List<Journal> _tempJournalEntry = new List<Journal>();
    public string _entryDate;
    public string _promptQuestion;
    public string _journalEntry;

    public void JournalEntry()
    {
        PromptGenerator question = new PromptGenerator();
        Console.WriteLine("Please enter your response to the following prompt:");
        question.RandomNumber();  

    }
}