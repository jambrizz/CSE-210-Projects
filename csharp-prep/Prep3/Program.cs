using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        do
        {
            Console.WriteLine("Hello Prep3 World!");
    
            Random randomGenerator = new Random();
            int num = randomGenerator.Next(1, 101);
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");
            Console.Write("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (guess != num)
            {
                if (guess > num)
                {
                    Console.WriteLine("Your guess was too high.");
                    count++;
                }
                else
                {
                    Console.WriteLine("Your guess was too low.");
                    count++;
                }

                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            if (guess == num)
            {
                Console.WriteLine("You guessed correctly!");
                count++;
            }
            Console.WriteLine($"It took you {count} guesses.");
            Console.Write("Would you like to play again? (yes/no) ");
            answer = Console.ReadLine();
        } 
        while (answer == "yes");
        if (answer == "no")
        {
            Console.WriteLine("Thank you for playing, goodbye!");
        }
    }
}