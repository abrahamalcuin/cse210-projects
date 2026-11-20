// Exceeds Requirements: Added Tiers to Gamify it even more.
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string menuOptions = "Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the menu: ";
        string goalMenu = "The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of goal would you like to create? ";
        List<Goal> goals = new List<Goal> { };

        int score = 0;
        int userInput = 0;
        int goalInput = 0;

        while (userInput != 6)
        {
            Console.Clear();
            string tier = "Beginner";

            if (score >= 5000)
            {
                tier = "Hyper Achiever";
            }
            else if (score >= 3000)
            {
                tier = "Overachiver";
            }
            else if (score >= 2000)
            {
                tier = "Achiever";
            }
            else if (score >= 1000)
            {
                tier = "Goal Getter";
            }
            Console.WriteLine($"You have {score} points.\nTier: {tier}\n");
            Console.WriteLine(menuOptions);
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine(goalMenu);
                goalInput = int.Parse(Console.ReadLine());

                if (goalInput == 1)
                {
                    Console.Write("Goal Name: ");
                    string goalName = (Console.ReadLine());
                    Console.Write("Goal Description: ");
                    string goalDesc = (Console.ReadLine());
                    Console.Write("Points Worth: ");
                    int points = int.Parse(Console.ReadLine());

                    SimpleGoal goal = new SimpleGoal(goalName, goalDesc, points);
                    goals.Add(goal);
                }
                else if (goalInput == 2)
                {
                    Console.Write("Goal Name: ");
                    string goalName = (Console.ReadLine());
                    Console.Write("Goal Description: ");
                    string goalDesc = (Console.ReadLine());
                    Console.Write("Points Worth: ");
                    int points = int.Parse(Console.ReadLine());

                    EternalGoal goal = new EternalGoal(goalName, goalDesc, points);
                    goals.Add(goal);
                }
                else if (goalInput == 3)
                {
                    Console.Write("Goal Name: ");
                    string goalName = (Console.ReadLine());
                    Console.Write("Goal Description: ");
                    string goalDesc = (Console.ReadLine());
                    Console.Write("Points Worth: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("Required Repetitions for Completion: ");
                    int repetitionRequirement = int.Parse(Console.ReadLine());
                    Console.Write("Bonus Points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    ChecklistGoal goal = new ChecklistGoal(goalName, goalDesc, points, repetitionRequirement, bonusPoints);
                    goals.Add(goal);
                }
            }

            else if (userInput == 2)
            {
                Console.Clear();
                foreach (Goal goal in goals)
                {
                    string marker = goal.IsComplete() ? "[X]" : "[ ]";
                    Console.WriteLine($"{marker} Goal Name: {goal.GetGoalName()}\nGoal Description: {goal.GetGoalDesc()}\npoints: {goal.GetPoints()}\n");
                    if (goal is ChecklistGoal checklist)
                    {
                        Console.WriteLine($"Completed {checklist.GetTimesCompleted()}/{checklist.GetRepetitionRequirement()} times");
                    }
                }
                Console.Write("Press Enter to Return to Menu");
                Console.ReadLine();
            }

            else if (userInput == 3)
            {
                Console.Write("Filename to save: ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(score);
                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
            }

            else if (userInput == 4)
            {
                Console.Write("Filename to load: ");
                string filename = Console.ReadLine();
                string[] lines = File.ReadAllLines(filename);
                score = int.Parse(lines[0]);
                goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string name = Uri.UnescapeDataString(parts[1]);
                    string description = Uri.UnescapeDataString(parts[2]);
                    int points = int.Parse(parts[3]);

                    if (parts[0] == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal(name, description, points, bool.Parse(parts[4])));
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        goals.Add(new ChecklistGoal(name, description, points,
                            int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    }
                }
            }

            else if (userInput == 5)
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}, {goals[i].GetGoalName()}");
                }

                Console.Write("Which goal did you accomplish? ");
                int selection = int.Parse(Console.ReadLine()) - 1;

                int earnedPoints = goals[selection].RecordEvent();
                score += earnedPoints;

                Console.WriteLine($"You earned {earnedPoints} points! Total: {score}");

                Console.Write("Press Enter to return to the menu.");
                Console.ReadLine();
            }
        }
    }
}
