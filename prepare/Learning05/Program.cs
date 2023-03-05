using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.Clear();
        Square square1 = new Square("blue", 5);
        shapes.Add(square1);
        
        Rectangle rectangle1 = new Rectangle("red", 5, 10);
        shapes.Add(rectangle1);
        
        Circle circle1 = new Circle("yellow", 5);
        shapes.Add(circle1);
        
        foreach (var item in shapes)
        {
            Console.WriteLine(item.GetColor() + " " + item.GetArea());
        }
    }
}