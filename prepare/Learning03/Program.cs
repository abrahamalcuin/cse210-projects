using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Random random = new Random();
        Fraction fraction5 = new Fraction();
        
        for (int i = 1; i <= 20; i++)
        {
            int randomTop = random.Next(1,100);
            int randomBottom = random.Next(1,100);

            fraction5.SetTop(randomTop);
            fraction5.SetBottom(randomBottom);

            Console.WriteLine($"Fraction {i+1}: string: {fraction5.GetFractionString()} Number: {fraction5.GetDecimalValue}");
        }
    }
}