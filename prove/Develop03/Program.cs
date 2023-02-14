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
            //Word word = new Word();
            Reference reference = new Reference("Philippians", "4", "13");
            Console.Write($"{reference.GetReference()}");
            scripture.Verses();
            /*
            for (int i = 0; i < word.philC4V9List.Count; i++)
            {
                Console.Write($"{word.philC4V9List[i]}" + " ");
            }
            */
            runProgram = false;
            

            /*
            for (int i = 0; i < word.multiple.Length; i++)
            {
                Console.Write($"{word.multiple[i]}" + " ");
            }
            runProgram = false;
            */
            /*
            Console.WriteLine("Scripture Mermorization App");
            Console.WriteLine("To start the program type start and press enter");
            Console.WriteLine("To quit the program type quit and press enter");
            string userInput = Console.ReadLine();

            if (userInput == "start")
            {
                Console.WriteLine("The program has started");
            }
            else if (userInput == "quit")
            {
                Console.WriteLine("The program has quit");
                runProgram = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            */
        }
        while (runProgram == true);
    }
}