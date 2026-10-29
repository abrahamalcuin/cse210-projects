using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignment1 = new Assignments("Joseph Owens", "Fractions");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Jonathan Wilson", "Linear Regression", "8.2", "9-13");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("James Micheal", "Philosophy", "The Republic");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());


    }
}