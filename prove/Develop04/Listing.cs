using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private readonly List<string> _listingPrompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public Listing() : base("Listing", "This activity helps you think broadly about positive aspects of your life.") { }

    public int RunListingActivity()
    {
        DisplayStartMessage();
        Console.WriteLine(_listingPrompts[new Random().Next(_listingPrompts.Count)]);
        Countdown(5);

        Console.WriteLine("Start listing items:");
        int count = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("- ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndMessage();
        return count;
    }
}
