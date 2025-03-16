public class EternalGoal : Goal
{
    // Constructor - an "eternal" goal never ends, just accumulates progress
    public EternalGoal(string title, string details, int rewardPoints) 
        : base(title, details, rewardPoints) { }

    // No completion, just continuous progress
    public override void RecordEvent()
    {
        Console.WriteLine($"Nice! You earned {Points} points for making progress on '{Name}'. Keep it up!");
    }

    // Eternal goals are never "done," so we just show an infinite symbol
    public override string GetStatus()
    {
        return "[∞] Ongoing - Keep going!";
    }

    // Save goal details in a simple format
    public override string SaveToFile()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
