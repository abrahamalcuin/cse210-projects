using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>(); 
        int tracker = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (tracker == 0)
        {
            Console.WriteLine("Enter number: ");
            int userNum = int.Parse(Console.ReadLine());
            if (userNum == 0)
            {
                tracker = 1;
            }
            else
            {
            numbers.Add(userNum);
            }
        }
        int total = numbers.Sum();
        Console.WriteLine($"The Sum is: {total}");

        double average = numbers.Average();
        Console.WriteLine($"The average is {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");





    }
}