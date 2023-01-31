using System.IO;

public class File
{
    //This is the default file name
    public string _fileName = "Journal.txt";

    //This is the test file name to switch between files to test the LoadFile() method
    public string _testFileName = "Test.txt";

    //This is the user created file name
    public string userCreatedFileName = "";

    //This is the user loaded file name
    public string userLoadedFileName = "";

    //This is the boolean to check if the user is working on a loaded file
    //if false then the user is not working on a loaded file
    //if true then the user is working on a loaded file
    public bool workingOnLoadFile = false;

    //string[] lines = System.IO.File.ReadAllLines("Journal.txt");

    public void SaveFile()
    {
        Console.WriteLine("Please enter a name for your file, don't forget the .txt at the end");
        userCreatedFileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(userCreatedFileName, true))
        {
            
        }
    }

    public void LoadFile()
    {
        //File file = new File();
        Console.WriteLine("What is the name of the file you want to load? don't forget the .txt at the end");
        string fileName = Console.ReadLine();

        if (fileName != null)
        {
            Console.WriteLine($"{workingOnLoadFile}");
            workingOnLoadFile = true;
            userLoadedFileName = fileName;
            Console.WriteLine($"{workingOnLoadFile} {userLoadedFileName}");
        }
        else
        {
            Console.WriteLine("File does not exist! Please try again.");
        }
    }

    public void CreateFileName()
    {
        
    }

    //TODO fix the display method to display the correct file selected by the user.
    public void Display()
    {
      if (workingOnLoadFile == true)
      {
        string[] lines = System.IO.File.ReadAllLines($"{userLoadedFileName}");
        foreach (string line in lines)
        {
          Console.WriteLine(line);
        }  
      }
      else
      {
        string[] lines = System.IO.File.ReadAllLines($"{_fileName}");
        foreach (string line in lines)
        {
          Console.WriteLine(line);
        }  
      }
    }
}