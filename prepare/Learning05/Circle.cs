using System;
using System.Collections.Generic;

public class Circle : Shape
{
    private double _radius;

    //Constructor for Circle
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //Override GetArea method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}