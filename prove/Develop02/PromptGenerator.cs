using System;

public class PromptGenerator
{
    public int _promptNumber;

    
    public void QuestionPrompt(int _promptNumber)
    {
        Entries entries = new Entries();

        List<string> _promptQuestions = new List<string>()
        {
            "What was your highlight of this day?",
            "What is something that you are grateful for today?",
            "What is something that you wish you could have done differently today?",
            "What is something that you learned today?",
            "What is something that you are looking forward to tomorrow?"
        };

        string question = _promptQuestions[_promptNumber];
        Console.WriteLine("Please enter your response to the following prompt:");    
        Console.WriteLine($"{question}");
        string userReply = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        entries._entryDate = theCurrentTime.ToString("MM/dd/yyyy");
        entries._promptQuestion = question;
        entries._journalEntry = userReply;
        
        entries.JournalEntry();
        //Entries entries = new Entries();
        //entries._journalEntry = userReply;
        //entries._promptQuestion = question;


    }

    public void RandomNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 5);
        _promptNumber = randomNumber;
        QuestionPrompt(_promptNumber);
    }

    public void UniquePrompt()
    {
        
    }
}