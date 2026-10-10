using System;
using System.Linq;

public class Files
{
    public void SaveJournal(string fileName, Journal journal)
    {
        File.WriteAllLines($"{fileName}.txt", journal._journalEntries);
    }

    public void LoadJournal(string fileName, Journal journal)
    {
        List<string> loadFile = File.ReadAllLines($"{fileName}.txt").ToList();

        journal._journalEntries = loadFile;
    }
}
