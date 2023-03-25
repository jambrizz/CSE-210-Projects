using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

public class File
{
    public void SaveFile(string _fileName, List<string> list1, List<string> list2)
    {

    }
    
    public void LoadFile(string _fileName)
    {

    }

    public void DisplayListContents(List<string> list)
    {
        for (int i = 0; i < list.Count;)
        {
            int j = i + 1;
            Console.WriteLine($"{j}. {list[i]}");
            i++;
        }
    }
}