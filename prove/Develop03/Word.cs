using System;

//Word - Keeps track of a single word and whether it is shown or hidden.

public class Word
{
    private List<int> _savedIndexes = new List<int>();
    
    //TODO change public to private once testing is complete
    public List<string> philC4V9List = new List<string>()
    {
        "I",
        "can",
        "do",
        "all",
        "things",
        "through", 
        "Christ", 
        "which",
        "strengtheneth",
        "me."
    };

    //TODO change public to private once testing is complete
    public List<string> multiple = new List<string>()
    {
        
    };

    private int[] hiddenWord = {
        
    };

    public void Words()
    {

    }

    public void Hide()
    {

    }

    public void Show()
    {

    }

    public string GetWord()
    {
        //TODO fix the return below
        return "test";
    }

    public string GetHiddenWord()
    {
        //TODO fix the return below
        return "test";
    }

    public string SetWord()
    {
        //TODO fix the return below
        return "test";
    }
}