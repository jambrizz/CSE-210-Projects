using System;
using System.Collections.Generic;
using System.IO;

public class Options : Goal
{
    private string _fileName;

    private List<string> _list;

    public Options(string fileName, List<string> List)
    {
        _fileName = fileName;
        _list = List;
    }

    public Options(List<string> List)
    {
        _list = List;
    }
    
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    
    public void SaveGoals(string _fileName, List<string> _list)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"TotalScore:{GetScore()}");
            foreach (var item in _list)
            {
                outputFile.WriteLine(item);
            }
        }
    }

    //TODO: fix the While loop or change it to a for loop
    public void LoadFile(string _fileName, List<string> List)
    {
        using (StreamReader inputFile = new StreamReader(_fileName))
        {
            int count = File.ReadAllLines(_fileName).Length;
            for (int i = 0; i < count;)
            {
                List.Add(inputFile.ReadLine());
                i++;
            }
        }
    }

    public void DisplayGoalsFromTxt(List<string> list)
    {
        //Console.Clear();
                //TODO update the removePartOfString so it handles object names that identify parts of the string that need to be removed.
                string [] removePartOfString = {"Simple:", "Eternal:", "Checklist:", "Name:", "Description:", "Score:", "Bonus:", "Denominator:", "Numerator:", "Status:", ",", "True", "False", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
                Console.WriteLine(list.Count);
                Console.WriteLine("\n");
                for (int i = 1; i < list.Count;)
                {
                    Console.Write(i + ". ");
                    string goalItem = list[i];
                    foreach (var part in removePartOfString)
                    {
                        goalItem = goalItem.Replace(part, "");
                        //i++;
                    }
                    i++;
                    Console.Write(goalItem + "\n");
                };
                Console.WriteLine("\n"); 
    }
    //TODO: fix the method below so it displays the goals from the list but does not add the same item to the list twice.
    public void DisplayGoalsFromList(List<string> list)
    {
        Console.WriteLine("\n");
        for (int i = 1; i < list.Count;)
        {
            Console.Write(i + ". ");
            string goalItem = list[i];
            i++;
            Console.Write(goalItem + "\n");
        };
        Console.WriteLine("\n");
    }

    public override string NewGoal()
    {
        throw new NotImplementedException();
    }

    /*
    public override string NewGoal()
    {
        return "";
    }
    */
}