using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userGrade = Console.ReadLine();

        int gradeInt = int.Parse(userGrade);
        string secondNum = userGrade.Substring(1,1);
        int secondNumInt = int.Parse(secondNum);

        string letter = "N/A";
        string modifier = " ";

        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >=80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else if (gradeInt <60)
        {
            letter = "F";
        }

        if (secondNumInt >= 7 && letter != "A" && letter != "F")
        {
            modifier = "+";
        }
        else if (secondNumInt < 3 && letter != "F")
        {
            modifier = "-";
        }


        if (letter == "C" || letter == "D" || letter == "F")
        {
            Console.WriteLine($"Your letter grade is {letter}{modifier}, you'll do better next time!");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letter}{modifier}, congratulations on passing the class!");
        }
    }
}