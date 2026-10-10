using System;
using System.Diagnostics.Tracing;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Entry entry = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        Files files = new Files();
        StartupSettings startupsettings = new StartupSettings();
        int menuSelection;

        do
        {
            menuSelection = int.Parse(menu.GetMenuSelection());

            if (menuSelection == 1)
            {
                entry.SetDate();
                string prompt = promptGenerator.GeneratePrompt();
                entry.SetPrompt(prompt);
                Console.WriteLine(prompt);
                entry.GetUserEntry();
                Console.WriteLine(entry.StoreEntry());
                journal.AddEntry(entry.StoreEntry());
            }

            else if (menuSelection == 2)
            {
                journal.DisplayAllEntries();
            }

            else if (menuSelection == 3)
            {
                Console.WriteLine("What would you like to name your journal file?");
                string fileName = Console.ReadLine();
                files.SaveJournal(fileName, journal);
            }

            else if (menuSelection == 4)
            {
                Console.WriteLine("What journal would you like to load in?");
                string fileName = Console.ReadLine();
                files.LoadJournal(fileName, journal);
            }
// EXCEEDS REQUIREMENTS FEATURE: 
// Think of other problems that keep people from writing in their journal and address one of those. - One problem people face when journaling is forgetting to journal, I've created a feature
// that lets a person enable a setting that makes the program run on startup of their Windows PC. This makes it easier to journal as it provides a trigger for them to do it.
// 
// REQUIREMENTS FOR FEATURE TO WORK: 
// 1. This only works on WINDOWS machines with .NET SDK installed
// 2. This requires that the _projectPath attribute be changed within StartupSetting.cs to point to the project directory. 
            else if (menuSelection == 5)
            {
                Console.WriteLine("This setting enables the journal app to begin on PC startup, what would you like to do? \n1. Turn on\n2. Turn off");
                string userEntry = Console.ReadLine();
                if (int.Parse(userEntry) == 1){
                    startupsettings.TurnOnStartup();
                    Console.WriteLine("Journal will now open on startup.");
                }
                else if (int.Parse(userEntry) ==2)
                {
                    startupsettings.TurnOffStartup();
                    Console.WriteLine("Journal will no longer open on startup.");
                }
            }

        } while (menuSelection != 6);
    }
}
