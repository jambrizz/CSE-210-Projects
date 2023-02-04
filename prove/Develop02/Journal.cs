using System;

public class Journal
{
    public int _featureSelection;

    public void FeatureSelection(int _featureSelection)
    {
        //Entries entries = new Entries();
        PromptGenerator prompt = new PromptGenerator();
        File file = new File();


        if (_featureSelection == 1)
        {
            file.Display();
        }
        else if (_featureSelection == 2)
        {
            prompt.RandomNumber();
        }
        else if (_featureSelection == 3)
        {
            file.LoadFile();
        }
        else if (_featureSelection == 4)
        {
            file.SaveFile();
        }
        else if (_featureSelection == 5)
        {
            Console.WriteLine("Quit");
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}