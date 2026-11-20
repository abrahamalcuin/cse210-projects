using System;

public class SimpleGoal : Goal
{
    private bool _completedStatus = true;

    public SimpleGoal(string goalName, string goalDesc, int points, bool completedStatus = false)
        : base(goalName, goalDesc, points)
    {
        _completedStatus = completedStatus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _completedStatus = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _completedStatus;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{base.GetStringRepresentation()}|{_completedStatus}";
    }
}
