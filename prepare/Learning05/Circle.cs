using System;
using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    {
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        return (_radius * _radius) * 3.14;
    }
}