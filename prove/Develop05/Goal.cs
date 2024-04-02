using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual string RecordEvent()
    {
        return "";
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
}