using System;
using System.Collections.Generic;

public class Rectangle : Shape
{
    private double _length;

    private double _width;

    //Constructor for Rectangle
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //Override GetArea method
    public override double GetArea()
    {
        return _length * _width;
    }
}