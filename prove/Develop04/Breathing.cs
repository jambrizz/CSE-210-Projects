using System;
using System.Collections.Generic;

public class Breathing : Activity
{
    private string _breathIn;
    private string _breathOut;

    Activity activity = new Activity();

    public void WelcomeBreathing()
    {
        Console.WriteLine("Welcome to the Breathing Activity \n");
        Console.WriteLine("This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. \n");
        Console.Write("How long, in seconds, would you like for your session to be? ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You have selected to have your session be " + userInput + " seconds long \n");
        
    }

    public void BreathingDisplay()
    {

    }

    public void PausingText()
    {

    }

    public void EndofActivity()
    {
        
        Console.WriteLine($"You have completed another {activity.GetSeconds()} seconds of Breathing Activity. \n");
    }
}

