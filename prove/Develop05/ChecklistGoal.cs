using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override string RecordEvent()
    {
        int points = int.Parse(_points);
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            points += _bonus;
        }
        string spoints = points.ToString();
        Console.WriteLine($"Congradulation! You have earned {spoints} points!");
        return spoints;
    }
    public override bool IsComplete()
    {
        bool complete = false;
        if (_amountCompleted == _target)
        {
            complete = true;
        }
        return complete;
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        string representation = $"ChecklistGoal@{_shortName}@{_description}@{_points}@{_amountCompleted}@{_target}@{_bonus}";
        return representation;
    }
    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }
}