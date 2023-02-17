using System;
using System.Collections.Generic;

class Program
{
        
    static void Main(string[] args)
    {
        bool runProgram = true;

        do
        {
            Scriptures scripture = new Scriptures();
            Word word = new Word();
            Reference reference = new Reference("Philippians", "4", "13");
            Console.Write($"{reference.GetReference()}");
            scripture.Verses(word.philC4V9List);
            word.wordCount(word.philC4V9List);
            word.pickThreeWords();
            word.pickThreeWords();
            word.pickThreeWords();
            //word.pickThreeWords();
            //word.pickThreeWords();
            foreach (int i in word.hiddenWords)
            {
                Console.WriteLine($"{i}");
            }
            //Console.WriteLine($"{word.listLenght[0]}");
            //Console.WriteLine($"{word.wordCount(word.philC4V9List)}");
            //Console.WriteLine($"{word.wordCount(word.almaC7V11and12)}");
            //Console.WriteLine($"{word.RandomNumberGenerator()}"); }")
           
            runProgram = false;
        
        }
        while (runProgram == true);
    }
}