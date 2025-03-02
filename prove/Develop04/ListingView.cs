using System;
using System.IO;

public class ListingView
{
    private const string _filePath = "MindfulnessLog.txt";

    public void DisplayListingLog()
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine("No log file found. Please complete some Listing activities first.");
            return;
        }

        Console.WriteLine("Listing Activity Log:\n");
        string[] logEntries = File.ReadAllLines(_filePath);
        bool foundEntries = false;

        foreach (string entry in logEntries)
        {
            if (entry.Contains("Listing"))
            {
                Console.WriteLine(entry);
                foundEntries = true;
            }
        }

        if (!foundEntries)
        {
            Console.WriteLine("No Listing entries found in the log.");
        }
    }
}
