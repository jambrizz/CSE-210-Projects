using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        if (File.Exists(_fileName) == true)
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                foreach (var item in _list)
                {
                    outputFile.WriteLine(item);
                }
            }
        }
        else
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
    }

    public void SaveToExistingFile(string _fileName, List<string> _list)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {
            outputFile.WriteLine($"TotalScore:{GetScore()}");
            foreach (var item in _list)
            {
                outputFile.WriteLine(item);
            }
        }
    }

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

        for (int i = 1; i < list.Count;)
        {
            string line = list[i];
            //string emptyCheckBox = "[ ]";
            bool checkBoxStatus = line.Contains("[ ]");
            
            if (checkBoxStatus == true)
            {
                string [] seperator = {","};
                string [] removeIdentifiers = {"Name:", "Description:"};

                int positionOfCheckBox = list[i].IndexOf("[", 3);
                string checkBox = list[i].Substring(positionOfCheckBox);
                string [] checkBoxArray = checkBox.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                string checkBoxArrayString = checkBoxArray[0];

                int positionOfName = list[i].IndexOf("Name:");
                string nameAndDescription = list[i].Substring(positionOfName);
                string [] nameArray1 = nameAndDescription.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                string nameWithIdentifier = nameArray1[0];
                

                string displayEntry = i + ". " + checkBoxArrayString + " " + nameWithIdentifier;
                foreach (string item in removeIdentifiers)
                {
                    displayEntry = displayEntry.Replace(item, "");
                }
                Console.WriteLine(displayEntry);
                i++;
            }
            else
            {
                string [] seperator = {","};
                string [] removeIdentifiers = {"Name:", "Description:"};

                int positionOfCheckBox = list[i].IndexOf("[", 3);
                string checkBox = list[i].Substring(positionOfCheckBox);
                string [] checkBoxArray = checkBox.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                string checkBoxArrayString = checkBoxArray[0];

                int positionOfName = list[i].IndexOf("Name:");
                string nameAndDescription = list[i].Substring(positionOfName);
                string [] nameArray1 = nameAndDescription.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                string nameWithIdentifier = nameArray1[0];
                

                string displayEntry = i + ". " + checkBoxArrayString + " " + nameWithIdentifier;
                foreach (string item in removeIdentifiers)
                {
                    displayEntry = displayEntry.Replace(item, "");
                }
                Console.WriteLine(displayEntry);
                i++;
            }
        }
       
    }
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
}