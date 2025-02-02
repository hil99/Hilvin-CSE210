using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "If I had one thing I could do over today, what would it be?",
        "What made me smile today?",
        "What am I most grateful for?",
        "What did I learn today?",
        "How did I make a difference today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}