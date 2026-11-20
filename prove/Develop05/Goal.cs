using System;
using System.Reflection.Metadata;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _points;

    public Goal(string goalName, string goalDesc, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDesc;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDesc()
    {
        return _goalDescription;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{Uri.EscapeDataString(_goalName)}|{Uri.EscapeDataString(_goalDescription)}|{_points}";
    }
}
