using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();  // Stores all goals
    private int _totalPoints = 0;  // Keeps track of total earned points

    // Adds a new goal to the list
    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }

    // Displays all goals with their status
    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].Name} ({_goals[i].Description})");
        }
        Console.WriteLine($"\nTotal Points: {_totalPoints}");
    }

    // Records progress on a specific goal
    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.WriteLine("⚠ Invalid goal number. Please try again.");
            return;
        }

        Goal selectedGoal = _goals[goalIndex - 1];
        selectedGoal.RecordEvent();
        _totalPoints += selectedGoal.Points;

        // If it's a ChecklistGoal and now completed, add bonus points
        if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
        {
            _totalPoints += checklistGoal.BonusPoints;
        }
    }

    // Saves all goals and points to a file
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.SaveToFile());
            }
            writer.WriteLine(_totalPoints);  // Save total points separately
        }
        Console.WriteLine("✅ Goals successfully saved!");
    }

    // Loads goals and points from a file
    public void LoadGoals(string filePath)
    {
        _goals.Clear();  // Reset current goals

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (string.IsNullOrWhiteSpace(line)) continue; // Ignore empty lines

                string[] parts = line.Split('|');

                switch (parts[0])
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;

                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(
                            parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), 
                            int.Parse(parts[6]), int.Parse(parts[4]), bool.Parse(parts[7])
                        ));
                        break;

                    default:
                        _totalPoints = int.TryParse(line, out int points) ? points : _totalPoints;
                        break;
                }
            }
        }
        Console.WriteLine("📂 Goals successfully loaded!");
    }
}
