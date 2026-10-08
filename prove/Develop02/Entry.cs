using System;

public class Entry
{
    
    public string _dateToday;
    public string _journalPrompt;
    public string _journalEntry;


    public void SetDate()
    {
        string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

        _dateToday = currentDate;
    }

    public void GetUserEntry()
    {
        _journalEntry = Console.ReadLine();

    }

    public void SetPrompt(string prompt)
    {
        _journalPrompt = prompt;
    }

    public string StoreEntry()
    {
        return ($"Date: {_dateToday} Prompt: {_journalPrompt} \nEntry: {_journalEntry}"); 
    }
    



    

}

