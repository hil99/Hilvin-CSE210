using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry._promptText}");
                writer.WriteLine($"Entry: {entry._entryText}");
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        Entry currentEntry = null;

        foreach (string line in lines)
        {
            if (line.StartsWith("Date:"))
            {
                currentEntry = new Entry();
                currentEntry._date = line.Substring(6); 
                _entries.Add(currentEntry);
            }
            else if (line.StartsWith("Prompt:"))
            {
                currentEntry._promptText = line.Substring(8);
            }
            else if (line.StartsWith("Entry:"))
            {
                currentEntry._entryText = line.Substring(7); 
            }
        }
    }
}
