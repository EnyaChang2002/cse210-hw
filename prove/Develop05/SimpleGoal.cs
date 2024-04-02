using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override string RecordEvent()
    {
        Console.WriteLine($"Congradulation! You have earned {_points} points!");
        _isComplete = true;
        return _points;
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string representation = $"SimpleGoal@{_shortName}@{_description}@{_points}@{IsComplete()}";
        return representation;
    }
}