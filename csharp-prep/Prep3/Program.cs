using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        int guess = Convert.ToInt32(Console.ReadLine());

        while (guess != num)
        {
            if (guess > num)
            {
                Console.WriteLine("Your guess was too high.");
            }
            else
            {
                Console.WriteLine("Your guess was too low.");
            }

            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        if (guess == num)
        {
            Console.WriteLine("You guessed correctly!");
        }
        /*
        if (guess == num)
        {
            Console.WriteLine("You guessed correctly!");
        }
        else if (guess > num)
        {
            Console.WriteLine("Your guess was too high.");
        }
        else
        {
            Console.WriteLine("Your guess was too low.");
        }
        */
    }
}