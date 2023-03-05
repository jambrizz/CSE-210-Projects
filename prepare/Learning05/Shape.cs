using System;
using System.Collections.Generic;

public abstract class Shape
{
    protected string _color;

    //Getter
    public string GetColor()
    {
        return _color;
    }

    //Constructor for Shape
    public Shape(string color)
    {
        _color = color;
    }

    //Setter
    public void SetColor(string color)
    {
        _color = color;
    }

    //Abstract method
    public virtual double GetArea()
    {
        return 0;
    }
}