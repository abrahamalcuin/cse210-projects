using System;

public class ScriptureBank
{
    private List<Scripture> _scriptures;

    public ScriptureBank(List<Scripture> scriptures)
    {
        _scriptures = scriptures;
    }

    public void DisplayScriptureBank()
    {
        int i = 1;

        foreach (Scripture scripture in _scriptures)
        {
            Console.WriteLine($"{i}. {scripture.GetDisplayScripture()}\n");
            i += 1;
        }
    }

    public int GetScriptureChoice()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the scripture mastery app, please pick one of the following scriptures by typing their associated number (1,2,3...)\n");
        DisplayScriptureBank();
        int userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }

    public Scripture GetScripture(int userChoice)
    {
        return _scriptures[userChoice - 1];
    }

}

