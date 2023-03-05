using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square1 = new Square("blue", 5);
        Console.WriteLine($"Square1: {square1.GetColor()}, {square1.GetArea()}");

        Rectangle rectangle1 = new Rectangle("red", 5, 10);
        Console.WriteLine($"Rectangle1: {rectangle1.GetColor()}, {rectangle1.GetArea()}");
        
    }
}