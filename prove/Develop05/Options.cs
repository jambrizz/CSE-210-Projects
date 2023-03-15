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

    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    
    public void SaveGoals(string _fileName, List<string> _list)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{GetScore()}");
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
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                List.Add(line);
            }
        }
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