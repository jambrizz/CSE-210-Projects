using System;

public class PromptGenerator
{
    public int _promptNumber;
    
    public void QuestionPrompt(int _promptNumber)
    {
        //Entries entries = new Entries();

        int x = 0;

        List<string> _promptQuestions = new List<string>()
        {
            "What was your highlight of this day?",
            "What is something that you are grateful for today?",
            "What is something that you wish you could have done differently today?",
            "What is something that you learned today?",
            "What is something that you are looking forward to tomorrow?",
            "Who was the most influential person you interacted with today?",
            "What is something that you are proud of today?",
            "Did you learn anything new today?",
        };

        string question = _promptQuestions[_promptNumber];
        Console.WriteLine("Please enter your response to the following prompt:");    
        Console.WriteLine($"{question}");
        string userReply = Console.ReadLine();

        if (userReply != "")
        {
            Entries entries = new Entries();
            
            DateTime theCurrentTime = DateTime.Now;
            entries._tempJournalEntry.Add(new Entries() 
            { 
                _entryDate = theCurrentTime.ToString("MM/dd/yyyy"), 
                _promptQuestion = question, 
                _journalEntry = userReply 
            });
            
        entries.JournalEntry();
        }
        /*
        entries._entryDate = theCurrentTime.ToString("MM/dd/yyyy");
        entries._promptQuestion = question;
        entries._journalEntry = userReply;
        
        entries.JournalEntry();
        */


    }

    public void RandomNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 8);
        _promptNumber = randomNumber;
        QuestionPrompt(_promptNumber);
    }
}