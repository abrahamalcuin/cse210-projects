using System;
using System.IO.Enumeration;

public class Journal
{
    public List<String> _journalEntries = new List<String>();

    public void DisplayAllEntries()
    {
        foreach (string entry in _journalEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public void AddEntry(string userEntry)
    {
        _journalEntries.Add(userEntry);
    }
}
