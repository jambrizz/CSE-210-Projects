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

    public List<string> firstCorinthC16V14List = new List<string>()
    {
        "Let",
        "all",
        "your",
        "things",
        "be",
        "done",
        "with",
        "charity."
    };

    public List<string> almaC7V11and12 = new List<string>()
    {
        "And", "he", "shall", "go", "forth", "suffering", "pains", "and", "afflictions", "and", "temptations", "of", "every", "kind;", "and", "this", "that", "the", "word", "might", "be", "fulfilled", "which", "saith", "he", "will", "take", "upon", "him", "the", "pains", "and", "the", "sicknesses", "of", "his", "people.", "And", "he", "will", "upon", "him", "death,", "that", "he", "may", "loose", "the", "bands", "of", "death", "which", "bind", "his", "people;", "and", "he", "will", "take", "upon", "him", "their", "infirmities,", "that", "his", "bowels", "may", "be", "filled", "with", "mercy,", "according", "to", "the", "flesh,", "how", "to", "succor", "his", "people", "according", "to", "their", "infirmities." 
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