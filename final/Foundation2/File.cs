using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class File
{
    private string _fileName = "OrderArchive.txt";

    public void SaveToArchive(List<string> _list)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (var item in _list)
            {
               outputFile.WriteLine(item);
            }
        }
        
    }

    public void LoadArchive(List<string> List)
    {
        using (StreamReader inputFile = new StreamReader(_fileName))
        {
            int lines = _fileName.Count();
            Console.WriteLine(lines);
            /*
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                List.Add(line);
            }
            */
        }
    }
}