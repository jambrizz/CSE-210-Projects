using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // Create a new instance of the Job class
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Junior Software Engineer";
        job2._company = "Adobe";
        job2._startYear = 2020;
        job2._endYear = 2024;

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();
    }
}