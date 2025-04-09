using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a formatted header for the activity list
        Console.WriteLine("===== FITNESS ACTIVITY TRACKER =====");
        Console.WriteLine("Date: November 3, 2025\n");
        
        // Create activity collection and populate with different activities
        var activityJournal = new List<Activity>();
        
        // Create one of each activity
        var morningRun = new Running(5, 25, "03 Nov 2025");  // 5km in 25 minutes
        var afternoonCycle = new Cycling(10, "03 Nov 2025", 30);  // 10 min, 30km
        var eveningSwim = new Swimming(100, "03 Nov 2025", 50);  // 100 min, 50 laps
        
       
        
        // Display activity summaries with better formatting
        Console.WriteLine("ACTIVITY SUMMARIES:");
        Console.WriteLine("------------------");
        
         // Add activities to journal
        activityJournal.Add(morningRun);
        activityJournal.Add(afternoonCycle);
        activityJournal.Add(eveningSwim);
        foreach (var activity in activityJournal)
        {
            // Display each activity with additional formatting
            Console.WriteLine($"• {activity.GetSummary()}");
            Console.WriteLine("------------------");
        }
        
        // Add summary statistics
        Console.WriteLine("\nSUMMARY STATISTICS:");
        Console.WriteLine($"Total Activities: {activityJournal.Count}");
        
        // Calculate total minutes across all activities
        int totalMinutes = activityJournal.Sum(activity => activity.Minutes);
        
        Console.WriteLine($"Total Time: {totalMinutes} minutes");
        Console.WriteLine("===================================");
    }
}