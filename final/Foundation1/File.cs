using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

public class File
{
    public string _fileName;
    public void SaveFile(string fileName, List<string> list)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var item in list)
            {
                outputFile.WriteLine(item);
            }
        }
    }
    
    public void SaveTwoFiles(string fileName1, string fileName2, List<string> list1, List<string> list2)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName1))
        {
            foreach (var item in list1)
            {
                outputFile.WriteLine(item);
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileName2))
        {
            foreach (var item in list2)
            {
                outputFile.WriteLine(item);
            }
        }

    }
    public void LoadFile(string fileName, List<string> list)
    {
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string newLine;
            while ((newLine = inputFile.ReadLine()) != null)
            {
                list.Add(newLine);
            }
        }
    }

    public void LoadTwoFiles(string fileName1, string fileName2, List<string> list1, List<string> list2)
    {
        using (StreamReader inputFile = new StreamReader(fileName1))
        {
            string newLine;
            while ((newLine = inputFile.ReadLine()) != null)
            {
                list1.Add(newLine);
            }
        }

        using (StreamReader inputFile = new StreamReader(fileName2))
        {
            string newLine;
            while ((newLine = inputFile.ReadLine()) != null)
            {
                list2.Add(newLine);
            }
        }
    }

    public void DisplayListContents(List<string> list)
    {
        Console.WriteLine();
        for (int i = 0; i < list.Count;)
        {
            int j = i + 1;
            Console.WriteLine($"{j}. {list[i]}");
            i++;
        }
    }

    public void DisplaySelectedVideoComments(List<string> list, string videoId)
    {
        string newLine;
        foreach (string item in list)
        {
            newLine = item;
            if (newLine.Contains(videoId))
            {
                Console.WriteLine(newLine);
            }
        }

    }
}