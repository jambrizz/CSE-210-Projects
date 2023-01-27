using System;

public class Journal
{
    public int _featureSelection;

    public void FeatureSelection(int _featureSelection)
    {
        Entries entries = new Entries();

        if (_featureSelection == 1)
        {
            Console.WriteLine("Display");
        }
        else if (_featureSelection == 2)
        {
            entries.JournalEntry();
        }
        else if (_featureSelection == 3)
        {
            Console.WriteLine("Load");
        }
        else if (_featureSelection == 4)
        {
            Console.WriteLine("Save");
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

    public void Display()
    {
        
    }
}