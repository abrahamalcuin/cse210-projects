// EXCEEDS REQUIREMENTS: ADDED A SPECIAL ANIMATION TO BREATHING ACTIVITY.
using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time this week when you felt especially stressed.",
            "Think of a time this week when you felt overwhelmed by something you needed to do.",
            "Think of a time this week when something did not go the way you expected.",
            "Think of a time this week when you felt frustrated, anxious, or under pressure.",
            "Think of a time this week when you had too many things competing for your attention."
        };

        List<string> followUpQuestions = new List<string>
        {
            "What was happening when you first noticed that you felt stressed?",
            "What do you think caused most of the stress in that situation?",
            "Was the stress caused more by the situation itself or by how you were thinking about it?",
            "How did your body react to the stress?",
            "What thoughts were going through your mind at the time?",
            "Was there anything you felt you could not control?",
            "Did another person contribute to the stress? If so, how?",
            "How did you respond to the situation?",
            "Did your response make the stress better or worse?",
            "What helped you feel calmer afterward?",
            "Looking back, is there anything you would handle differently?",
            "Is there anything you could do in the future to reduce this kind of stress?",
            "What did this experience teach you about what tends to make you feel stressed?"
        };

        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        string menu = """
        Menu Options:
            1. Start breathing activity
            2. Start reflecting activity
            3. Start listing activity
            4. Quit
        Select a choice from the menu: 
        """;

        ReflectingActivity reflecting =
            new ReflectingActivity(reflectionPrompts, followUpQuestions);

        BreathingActivity breathing =
            new BreathingActivity();

        ListingActivity listing =
            new ListingActivity(listingPrompts);

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine(menu);
            int userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (userChoice == 1)
            {
                breathing.StartBreathingActivity();
            }
            else if (userChoice == 2)
            {
                reflecting.StartReflection();
            }
            else if (userChoice == 3)
            {
                listing.StartListing();
            }
            else if (userChoice == 4)
            {
                running = false;
            }
        }
    }
}
