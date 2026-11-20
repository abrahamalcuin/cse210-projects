using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDesc, int points)
        : base(goalName, goalDesc, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{base.GetStringRepresentation()}";
    }
}
