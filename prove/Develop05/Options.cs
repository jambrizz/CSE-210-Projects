using System;
using System.Collections.Generic;

public class Options
{
    private string _fileName;

    public Options(int score)
    {
    }

    public void SaveFile(string fileName)
    {
        _fileName = fileName;
    }

    public void LoadFile()
    {
        
    }

    /*
    public override string NewGoal()
    {
        return "";
    }
    */
}