using System;

public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //This Getter will return the value as a string in the format of numerator/denominator
    public string GetFractionString()
    {
        string value = $"{_top}/{_bottom}";
        return value;
    }

    //This Getter will return the value as a double
    public double GetDecimalValue()
    {
        double value = (double)_top / (double)_bottom;
        return value;
    }
}