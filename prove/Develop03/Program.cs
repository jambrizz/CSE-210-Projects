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
            scripture.Verses2(word.philC4V9List);
            Console.WriteLine($"{word.wordCount(word.philC4V9List)}");
           
            runProgram = false;
        
        }
        while (runProgram == true);
    }
}