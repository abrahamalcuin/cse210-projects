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
        
        List<string> LoadFile = File.ReadAllLines(fileName).ToList();

        journal._journalEntries = LoadFile;
    }

}