using System;

public class Journal
{
    public int _featureSelection;

    public void FeatureSelection(int _featureSelection)
    {
        //Entries entries = new Entries();
        PromptGenerator prompt = new PromptGenerator();
        File file = new File();

        //This is the feature selection for the user
        if (_featureSelection == 1)
        {
            //This is to display the fournal entries
            file.Display();
        }
        else if (_featureSelection == 2)
        {
            //This is to generate a random prompt to ask the user for a response to save to the journal
            prompt.RandomNumber();
        }
        else if (_featureSelection == 3)
        {
            //This is to load a file
            file.LoadFile();
        }
        else if (_featureSelection == 4)
        {
            //This is to save a file
            file.SaveFile();
        }
        else if (_featureSelection == 5)
        {
            //This is to quit the program
            Console.WriteLine("Thank you for using the Journal App, See you next time!");
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}