using System;
using System.Collections.Generic;

public class Breathing : Activity
{
    private readonly List<string> _breathingPrompts = new() { "Breathe in...", "Breathe out..." };

    public Breathing() : base("Breathing", "This activity helps you relax by guiding you through deep breathing.") { }

    public void RunBreathingActivity()
    {
        DisplayStartMessage();
        int seconds = 0;

        while (seconds < _duration)
        {
            foreach (var prompt in _breathingPrompts)
            {
                Console.WriteLine(prompt);
                Countdown(4);
                seconds += 4;
                if (seconds >= _duration) break;
            }
        }

        DisplayEndMessage();
    }
}
