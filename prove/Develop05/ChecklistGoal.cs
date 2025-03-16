public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }  // Total required to complete the goal
    public int CurrentCount { get; private set; }  // How many times it's been done so far
    public int BonusPoints { get; set; }  // Extra reward for full completion

    // Constructor - initializing values with some parameter adjustments
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int progress, bool isDone)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = progress;  // More intuitive than 'currentCount'
        IsCompleted = isDone;
    }

    // This method updates progress toward the goal
    public override void RecordEvent()
    {
        if (IsCompleted)  // Check first to avoid unnecessary logic
        {
            Console.WriteLine($"You've already completed '{Name}' and earned the bonus!");
            return;
        }

        CurrentCount++;  // Increment progress
        Console.WriteLine($"Nice work! You gained {Points} points for working on '{Name}'.");

        // Check if the goal is fully achieved
        if (CurrentCount >= TargetCount)
        {
            IsCompleted = true;
            Console.WriteLine($"Awesome! '{Name}' is fully completed. You earned a bonus of {BonusPoints} points!");
        }
    }

    // Returns a formatted status of the goal
    public override string GetStatus()
    {
        // Added a little spacing for readability
        return IsCompleted 
            ? $"[✔] {Name} - {CurrentCount}/{TargetCount} (Completed!)"
            : $"[ ] {Name} - {CurrentCount}/{TargetCount}";
    }

    // Save goal progress in a formatted way for file storage
    public override string SaveToFile()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{CurrentCount}|{TargetCount}|{BonusPoints}|{IsCompleted}";
    }
}
