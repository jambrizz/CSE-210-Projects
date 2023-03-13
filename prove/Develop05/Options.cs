using System;
using System.Collections.Generic;
using System.IO;

public class Options : Goal
{
    private string _fileName;

    public Options(string fileName, List<string> List)
    {
        _fileName = fileName;
        SaveGoals(_fileName, List);
        //_score = score;
    }

    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    
    public void SaveGoals(string _fileName, List<string> List)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{GetScore()}");
            foreach (var item in List)
            {
                outputFile.WriteLine(item);
            }
        }
    }

    public void LoadFile()
    {
        
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