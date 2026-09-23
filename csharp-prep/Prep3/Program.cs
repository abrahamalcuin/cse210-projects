using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
       int magicNum;
       int userInt;
       int tryCount = 0;

    //    Console.WriteLine("What is the magic number?"); 
    //    magicNum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        magicNum = randomGenerator.Next(1,100);
        
       Console.WriteLine("What is your guess?"); 
        userInt = int.Parse(Console.ReadLine());

       while (userInt != magicNum)
        {
        
            if (userInt > magicNum){
                Console.WriteLine("Lower");
                Console.WriteLine("What is your guess?");
                userInt = int.Parse(Console.ReadLine());
                
            }
            else if (userInt <magicNum){
                Console.WriteLine("Higher");
                Console.WriteLine("What is your guess?");
                userInt = int.Parse(Console.ReadLine());
                
            }
            tryCount++;
        }
        Console.WriteLine($"Congratulations! You guessed it with {tryCount} tries!");
    }
}