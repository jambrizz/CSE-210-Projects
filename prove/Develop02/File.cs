using System.IO;
//using System.Collections.Generic;
using System.Dynamic;

public class File
{
    //This is the default file name
    public string _fileName = "Journal.txt";

    //This is the test file name to switch between files to test the LoadFile() method
    public string _testFileName = "Test.txt";
    //This is the path to the file
    public string path = @"prove\Develop02\";

    //This is the user created file name
    public string userCreatedFileName = "";

    //This is the variable to store the user created file name
    public string _userCreatedFileName = "";
    
    //This is the user loaded file name
    public List<File> _userLoadedFileName = new List<File>();
    
    //This is the variable to store the user loaded file name
    public string userLoadedFileName = "";

    //This is the boolean to check if the user is working on a loaded file
    //if false then the user is not working on a loaded file
    //if true then the user is working on a loaded file
    public bool workingOnLoadFile = false;

    //This method creates a new file
    public void SaveFile()
    {
        Console.WriteLine("Please enter a name for your file, don't forget the .txt at the end");
        userCreatedFileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(userCreatedFileName, true))
        {
            
        }
    }
    //This method loads a file and checks if it exists and if it does it saves the file name to a variable to create a path to the file later
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
            Display();
        }
        else
        {
            Console.WriteLine("File does not exist! Please try again.");
        }
    }

    //This method displays the file
    public void Display()
    {
        string[] lines = System.IO.File.ReadAllLines($"{_fileName}");
        foreach (string line in lines)
        {
          Console.WriteLine(line);
        }  
      
    }
}
