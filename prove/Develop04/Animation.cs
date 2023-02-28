using System;
using System.Collections.Generic;

public class Animation
{
    List<string> _animation = new List<string>()
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\"

    };

    public void AnimationDisplay()
    {
        foreach (string animation in _animation)
        {
            Console.Write(animation);
            System.Threading.Thread.Sleep(200);
            Console.Clear();
        }
    }
}