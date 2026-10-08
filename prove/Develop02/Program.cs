using System;
using System.Diagnostics.Tracing;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    { Menu menu = new Menu();
      Entry entry = new Entry();
      PromptGenerator promptGenerator = new PromptGenerator();
      Journal journal = new Journal();
      Files files = new Files();
      int menuSelection;
        do
        {
            menuSelection = int.Parse(menu.GetMenuSelection());

            if (menuSelection == 1){
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

        }while(menuSelection != 5);
    }
}