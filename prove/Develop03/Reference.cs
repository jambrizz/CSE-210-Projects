using System;
using System.Collections.Generic; // for Lists

//Reference - Keeps track of the book, chapter, and verse information.

public class Reference
{
    private string _books;
   
    private List <string> books = new List <string>
     {
        "Philippians"
     };
   
    private string _chapter;
   
    private List <string> chapter = new List <string>
     {
        "4" // Philippians
     };
    private string _verse;
   
    private List <string> verse = new List <string>
     {
        "13" // Philippians
     };
   
    public string GetReference()
    {
      _books = books[0];
      _chapter = chapter[0];
      _verse = verse[0];
      string message = $"{_books} {_chapter}:{_verse}";
      return message;
    }

    public Reference()
    {

    }

}