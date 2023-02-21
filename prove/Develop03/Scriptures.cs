using System;

//Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

public class Scriptures
{

    private List<Scriptures> _tempWords = new List<Scriptures>();

    private List<Scriptures> _wordIndex = new List<Scriptures>();

    private string _verse;
    
    public object Verses(string scriptRef, List<string> list)
    {
        Console.Write($"{scriptRef}");
        Word word = new Word();
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        word.wordCount(list);
        Console.WriteLine("");
        return list;
    }

    public object HideText(string scriptRef, List<string> list, List<int> hiddenWords)
    {

        Console.Write($"{scriptRef}");
        Word word = new Word();
        foreach (var item in list)
        {
            int wordLength = item.Length;
            if(hiddenWords.Contains(list.IndexOf(item)) == true)
            {
                for(int i = 0; i < wordLength;)
                {
                    Console.Write("_");
                    i++;
                }
                Console.Write(" ");
            }
            else
            {
                Console.Write(item + " ");
            }
        }
        return list;
    }
    
    
}