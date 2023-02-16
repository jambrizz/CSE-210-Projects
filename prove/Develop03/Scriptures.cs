using System;

//Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

public class Scriptures
{

    private List<Scriptures> _tempWords = new List<Scriptures>();

    private List<Scriptures> _wordIndex = new List<Scriptures>();

    private string _verse;
    
    //TODO fix the method below so it is the principle code to be run
    public object Verses(List<string> list)
    {
        Word word = new Word();
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        word.wordCount(list);
        return list;
    }
    
}