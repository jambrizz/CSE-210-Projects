using System;
using System.Collections.Generic; // for Lists

//Reference - Keeps track of the book, chapter, and verse information.

public class Reference
{
    private string _books;
   
    private string _chapter;
   
    private string _verse;
   
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