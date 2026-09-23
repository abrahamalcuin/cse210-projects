using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your Name?");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite Number?");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int PromptUserBirthYear()
    {
        Console.WriteLine("Please enter the year you were born:");
        int userBirthYear = int.Parse(Console.ReadLine());
        return userBirthYear;
    }

    static int SquareNumber(int number)
    {
        int SquaredNumber = number*number;
        return SquaredNumber;

    }

    static void DisplayResult()
    {
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userBirthYear = PromptUserBirthYear();
        int SquaredNumber = SquareNumber(userNumber);
        int YearsOld = DateTime.Now.Year - userBirthYear;

        Console.WriteLine($"{userName}, the square of your number is {SquaredNumber}");
        Console.WriteLine($"{userName}, you will turn / have turned {YearsOld} this year.");
        
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }
}