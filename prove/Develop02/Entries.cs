using System.IO;

public class Entries
{
    File file = new File();
    public List<Entries> _tempJournalEntry = new List<Entries>();
    
    public string _entryDate;
    public string _promptQuestion;
    public string _journalEntry;

    public void JournalEntry()
    {
        Console.WriteLine($"{file.workingOnLoadFile}");
        Console.WriteLine($"{file.userLoadedFileName}");

        if (file.workingOnLoadFile == true)
        {
            for(int i = 0; i < _tempJournalEntry.Count; i++)
            {
                using (StreamWriter outputFile = new StreamWriter(file.userLoadedFileName, true))
                {
                    outputFile.WriteLine($"{_tempJournalEntry[i]._entryDate}\n{_tempJournalEntry[i]._promptQuestion}\n{_tempJournalEntry[i]._journalEntry}\n");
                }
            }  
        }
        else
        {
            for(int i = 0; i < _tempJournalEntry.Count; i++)
            {
                using (StreamWriter outputFile = new StreamWriter(file._fileName, true))
                {
                    outputFile.WriteLine($"{_tempJournalEntry[i]._entryDate}\n{_tempJournalEntry[i]._promptQuestion}\n{_tempJournalEntry[i]._journalEntry}\n");
                }
            }
               
        }
    }
}