using System.IO;

public class File
{
    public string _fileName = "Journal.txt";
    string[] lines = System.IO.File.ReadAllLines("Journal.txt");

    public void SaveFile()
    {
        
    }

    public void LoadFile()
    {
        //File file = new File();
        Console.WriteLine("What is the name of the file you want to load? dont forget the .txt at the end");
        string fileName = Console.ReadLine();

        if(fileName == _fileName)
        {
            Console.WriteLine("File exists");
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    public void CreateFileName()
    {
        
    }

    public void Display()
    {
      
      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }  
    }
}