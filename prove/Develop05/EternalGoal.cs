using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override string RecordEvent()
    {
        Console.WriteLine($"Congradulation! You have earned {_points} points!");
        return _points;
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetStringRepresentation()
    {
        string representation = $"EternalGoal@{_shortName}@{_description}@{_points}@{IsComplete()}";
        return representation;
    }
    
}