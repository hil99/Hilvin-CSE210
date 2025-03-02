using System;
using System.Threading;

public class Activity
{
    protected string _activityName;
    protected int _duration;
    protected string _description;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void SetDuration(int duration) => _duration = duration;

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Starting {_activityName} activity. {_description}");
        Spinner();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Great job! You've completed the {_activityName} activity.");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
        Spinner();
    }

    protected void Spinner()
    {
        Console.Write("Preparing");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine("\n");
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
