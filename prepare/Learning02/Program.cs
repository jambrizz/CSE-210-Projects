using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

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
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "Senior Software Engineer";
        job3._company = "Google";
        job3._startYear = 2020;
        job3._endYear = 2022;

        Job job4 = new Job();
        job4._jobTitle = "Senior Software Engineer";
        job4._company = "Apple";
        job4._startYear = 2022;
        job4._endYear = 2025;

        Job job5 = new Job();
        job5._jobTitle = "Jr. Software Engineer";
        job5._company = "Amazon";
        job5._startYear = 2023;
        job5._endYear = 2025;

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        // Create a new instance of the Resume class
        Resume resume = new Resume();
        resume._name = "John Thompson";
        resume._jobs.Add(job1);
        resume._jobs.Add(job3);
        resume._jobs.Add(job4);

        Resume resume2 = new Resume();
        resume2._name = "Peter Parker";
        resume2._jobs.Add(job2);
        resume2._jobs.Add(job5);

        //Console.WriteLine(resume._jobs[0]._jobTitle);
        //Console.WriteLine(resume2._jobs[0]._jobTitle);
        //Console.WriteLine(resume._jobs.Count);
        //Console.WriteLine(resume2._jobs.Count);
        resume.DisplayResume();
        Console.WriteLine();
        resume2.DisplayResume();
        Console.WriteLine();

    }
}