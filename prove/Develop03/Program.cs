using System;
using System.Collections.Generic;

class Program
{
        
    static void Main(string[] args)
    {
        for (int i = 0; i < 1; i++)
        {
            Console.Clear();
            Scriptures scripture = new Scriptures();
            Word word = new Word();
            Console.WriteLine("Welcome to the Scripture Memorization App!");
            Console.WriteLine("Please Select an Option to Load a scripture to practice:");
            Console.WriteLine("1. Philippians 4:13");
            Console.WriteLine("2. 1 Corinthians 16: 14");
            Console.WriteLine("3. Alma 7: 11-12");
            int selection = Convert.ToInt32(Console.ReadLine());

            if(selection == 1)
            {
                Reference reference = new Reference("Philippians", "4", "13");
                string scriptRef = reference.GetReference();
                scripture.Verses(scriptRef, word.philC4V9List);
                Console.WriteLine("Hit enter to start or type 'quit' to exit.");
                string input = Console.ReadLine();

                bool runProgram = true;
                do
                {
                    word.wordCount(word.philC4V9List); 
                
                    if(input == "quit")
                    {
                        runProgram = false;
                    }
                    else if (input == "")
                    {
                        Console.Clear();
                        word.wordCount(word.philC4V9List);
                        word.pickThreeWords();
                        scripture.HideText(scriptRef, word.philC4V9List, word.hiddenWords);
                        input = Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a valid command.");
                        input = Console.ReadLine();
                    }

                    if(word.hiddenWords.Count == word.listLenght[0])
                    {
                        runProgram = false;
                    }
                
                }
                while (runProgram == true);
            } else if(selection == 2)
            {
                Reference reference = new Reference("1 Corinthians", "16", "14");
                string scriptRef = reference.GetReference();
                scripture.Verses(scriptRef, word.firstCorinthC16V14List);
                Console.WriteLine("Hit enter to start or type 'quit' to exit.");
                string input = Console.ReadLine();

                bool runProgram = true;
                do
                {
                    word.wordCount(word.firstCorinthC16V14List); 
                
                    if(input == "quit")
                    {
                        runProgram = false;
                    }
                    else if (input == "")
                    {
                        Console.Clear();
                        word.wordCount(word.firstCorinthC16V14List);
                        word.pickThreeWords();
                        scripture.HideText(scriptRef, word.firstCorinthC16V14List, word.hiddenWords);
                        input = Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a valid command.");
                        input = Console.ReadLine();
                    }

                    if(word.hiddenWords.Count == word.listLenght[0])
                    {
                        runProgram = false;
                    }
                
                }
                while (runProgram == true);
            } else if(selection == 3)
            {
                Reference reference = new Reference("Alma", "7", "11-12");
                string scriptRef = reference.GetReference();
                scripture.Verses(scriptRef, word.almaC7V11and12);
                Console.WriteLine("Hit enter to start or type 'quit' to exit.");
                string input = Console.ReadLine();

                bool runProgram = true;
                do
                {
                    word.wordCount(word.almaC7V11and12); 
                
                    if(input == "quit")
                    {
                        runProgram = false;
                    }
                    else if (input == "")
                    {
                        Console.Clear();
                        word.wordCount(word.almaC7V11and12);
                        word.pickThreeWords();
                        scripture.HideText(scriptRef, word.almaC7V11and12, word.hiddenWords);
                        input = Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a valid command.");
                        input = Console.ReadLine();
                    }

                    if(word.hiddenWords.Count == word.listLenght[0])
                    {
                        runProgram = false;
                    }
                
                }
                while (runProgram == true);
            } else
            {
                Console.WriteLine("Please enter a valid option.");
            }

            //fix this below
            //i++;          
            
        
        }
        
    }
}