public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string details, int rewardPoints) 
        : base(title, details, rewardPoints) { }

    public override void RecordEvent()
    {
        if (IsCompleted)
        {
            Console.WriteLine($"You've already completed '{Name}'. No additional points awarded.");
            return;
        }

        IsCompleted = true;
        Console.WriteLine($"Great job! You earned {Points} points for completing '{Name}'.");
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X] Completed" : "[ ] Not Completed";
    }
        public override string SaveToFile()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{IsCompleted}";
    }
}
