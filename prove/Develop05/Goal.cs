public abstract class Goal
{
    public string Name { get; set; }  // Short title of the goal
    public string Description { get; set; }  // A longer explanation
    public int Points { get; protected set; }  // Points awarded per progress
    public bool IsCompleted { get; protected set; }  // Tracks if goal is finished

    // Constructor - sets up basic goal properties
    public Goal(string title, string details, int rewardPoints)
    {
        Name = title;
        Description = details;
        Points = rewardPoints;
        IsCompleted = false;  // Default: not completed yet
    }

    // Every goal type needs to define how progress is recorded
    public abstract void RecordEvent();

    // Each goal should provide a custom status display
    public abstract string GetStatus();

    // Converts goal data to a savable format (e.g., for a file)
    public abstract string SaveToFile();
}
