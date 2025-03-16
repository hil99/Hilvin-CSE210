using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        
        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(manager);
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "5":
                    Console.Write("Enter the goal number to record: ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        manager.RecordEvent(goalIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                    break;
                case "6":
                    Console.WriteLine("Goodbye! See you next time.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal(GoalManager manager)
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select the type of goal: ");
        string type = Console.ReadLine()?.Trim();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid input. Points must be a number.");
            return;
        }

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                if (!int.TryParse(Console.ReadLine(), out int targetCount))
                {
                    Console.WriteLine("Invalid input. Target count must be a number.");
                    return;
                }

                Console.Write("Enter bonus points: ");
                if (!int.TryParse(Console.ReadLine(), out int bonusPoints))
                {
                    Console.WriteLine("Invalid input. Bonus points must be a number.");
                    return;
                }

                // Default values for ChecklistGoal
                manager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints, 0, false));
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                break;
        }
    }
}
