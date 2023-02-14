using System;
using System.Collections.Generic; // for Lists

//Reference - Keeps track of the book, chapter, and verse information.

public class Reference
{
    private string _books;
   /*
    private List <string> books = new List <string>
     {
        "Philippians",
        "1 Corinthians",
        "Alma"
     };
   */
    private string _chapter;
   /*
    private List <string> chapter = new List <string>
     {
        "4", // Philippians
        "16", // 1 Corinthians
        "7" // Alma
     };
   */
    private string _verse;
   /*
    private List <string> verse = new List <string>
     {
        "13", // Philippians
        "14",  // 1 Corinthians
        "11-12" // Alma
     };
   */
    public string GetReference()
    {
      string message = $"{_books} {_chapter}:{_verse} ";
      return message;
    }

    public Reference(string book, string chapter, string verse)
    {
         _books = book;
         _chapter = chapter;
         _verse = verse;
    }

}