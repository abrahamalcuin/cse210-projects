using System;

public class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("green", 4);
        Rectangle rq = new Rectangle("blue", 4, 8);
        Circle cir = new Circle("orange", 3);

        List<Shape> shapes = new List<Shape>
        {
            sq, rq, cir
        };
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The shape is color {shape.GetColor()}, and the area is {shape.GetArea()}");
        }
    }
}