using System;
using System.Collections.Generic;

public class Square : Shape
{
    private double _side;

    //Constructor for Square
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //Override GetArea method
    public override double GetArea()
    {
        return _side * _side;
    }
}