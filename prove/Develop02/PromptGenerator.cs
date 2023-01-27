using System;

public class PromptGenerator
{
    public int _promptNumber;

    public void QuestionPrompt(int _promptNumber)
    {
        List<string> _promptQuestions = new List<string>()
        {
            "What was your highlight of this day?",
            "What is something that you are grateful for today?",
            "What is something that you wish you could have done differently today?",
            "what is something that you learned today?",
            "What is something that you are looking forward to tomorrow?"
        };    
        Console.WriteLine(_promptQuestions[_promptNumber]);
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