using System.IO;

public class Entries
{
    public string _fileName = "Journal.txt";

    File file = new File();
    //public List<Entries> _tempJournalEntry = new List<Entries>();
    public string _entryDate;
    public string _promptQuestion;
    public string _journalEntry;

    public void JournalEntry()
    {

        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {
            outputFile.WriteLine($"{_entryDate}\n{_promptQuestion}\n{_journalEntry}\n");
        }
        /*
        _tempJournalEntry.Add(new Entries()
        {
            _entryDate = _entryDate, 
            _promptQuestion = _promptQuestion,
            _journalEntry = _journalEntry
        });
       
        foreach (Entries entry in _tempJournalEntry)
        {
            Console.WriteLine($"{entry._entryDate}\n{entry._promptQuestion}\n{entry._journalEntry}\n");
        }
        */
    }
}