using System;

//Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

public class Scriptures
{
    Word word = new Word();
    private List<Scriptures> _tempWords = new List<Scriptures>();

    private List<Scriptures> _wordIndex = new List<Scriptures>();

    private string _verse;

    public Scriptures(string verse)
    {
        _verse = verse;
    }

    //TODO fix the method below
    public string GetScriptures ()
    {
        string verses = foreach (var item in _verse)
        {
            
        };
        return verses;
    }

    //TODO fix the method below
    public string GetHiddenScriptures()
    {
        string verses = foreach (var item in _verse)
        {
            
        };
        return verses;
    }

}