using System;
using System.IO;

public class ActivityLogger
{
    private const string _logFilePath = "MindfulnessLog.txt";

    public static void LogActivity(string activityName, int duration, int itemCount = 0)
    {
        string logEntry = $"Activity: {activityName}";
        if (itemCount > 0) logEntry += $" - Items Listed: {itemCount}";
        logEntry += $", Duration: {duration} seconds, Time: {DateTime.Now}";

        try
        {
            File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
            Console.WriteLine("Activity logged successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging activity: {ex.Message}");
        }
    }
}

