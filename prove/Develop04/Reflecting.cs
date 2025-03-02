using System;
using System.Collections.Generic;

public class Reflecting : Activity
{
    private readonly List<string> _reflectingPrompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private readonly List<string> _reflectionQuestions = new()
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself?"
    };

    public Reflecting() : base("Reflecting", "This activity helps you reflect on times when you've shown strength and resilience.") { }

    public void RunReflectingActivity()
    {
        DisplayStartMessage();
        Random random = new Random();
        int seconds = 0;

        while (seconds < _duration)
        {
            Console.WriteLine(_reflectingPrompts[random.Next(_reflectingPrompts.Count)]);
            Countdown(10);
            seconds += 4;

            Console.WriteLine("Reflect on the following:");
            foreach (var question in _reflectionQuestions)
            {
                Console.WriteLine(question);
                Countdown(10);
                seconds += 4;
                if (seconds >= _duration) break;
            }
        }

        DisplayEndMessage();
    }
}
