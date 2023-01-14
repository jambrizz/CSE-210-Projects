using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when you are done:  ");
            userInput = Convert.ToInt32(Console.ReadLine());
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        }

        if (userInput == 0)
        {
            //1. sum of all numbers
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of all numbers is {sum}.");

            /*test to see all items in the list
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            //2. average of all numbers
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average of all numbers is {average}.");

            //3. Larget number
            int LargestNumber = numbers[0];
            foreach (int number in numbers)
            {
                if(number > LargestNumber)
                {
                    LargestNumber = number;
                }
            }
            Console.WriteLine($"The largest number in the list is {LargestNumber}.");       
        }

        /*
        do
        {
            Console.Write("Enter a list of numbers, type 0 when you are done:  ");
            userInput = Convert.ToInt32(Console.ReadLine());

            
        }
        while (userInput != 0);
        {
            numbers.Add(userInput);
        }
        if (userInput == 0)
        {
            //1. sum of all numbers
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of all numbers is {sum}.");

            //2. average of all numbers
            
            //3. largest number

        }
        */
    }

}