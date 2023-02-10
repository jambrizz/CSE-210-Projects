using System;
using System.Collections.Generic; // for Lists

public class Reference
{
    private string _book;

    private List <string> books = new List <string>
     {
        "Philippians",
        "Joshua",
        "John"
     };

    private int _chapter;

    private List <int> chapter = new List <int>
     {
        4, // Philippians
        1, // Joshua
        3, // John
     };

    private int _verse;

    private List <string> verse = new List <string>
     {
        "13: I can do all things through Christ which strengtheneth me.", // Philippians
        "9: Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the LORD thy God is with thee whithersoever thou goest.", // Joshua
        "16: For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", // John
     };

    public Reference()
    {

    }

    public Reference(int amountOfVerses)
    {

    }

}