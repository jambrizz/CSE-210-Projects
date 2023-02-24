using System;
using System.Collections.Generic;

public class Listing
{
    private int _count;

    List<string> _promptQuestions = new List<string>()
    {

    };

    public int RandomNumberGenerator()
    {
        Random random = new Random();
        int number = random.Next(0, _promptQuestions.Count);
        return number;
    }

    public void ListingDisplay()
    {

    }

    public void TimeToThink()
    {

    }
    //Change void to int once you have figure out the rest of the code.
    public void NumListedItems()
    {

    }

}