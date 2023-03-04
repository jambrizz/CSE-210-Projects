using System;
using System.Collections.Generic;

public class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        return _side * _side;
    }
}