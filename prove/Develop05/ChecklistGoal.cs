using System;

public class ChecklistGoal : Goal
{
    private int _repetitionRequirement;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string goalName, string goalDesc, int points,
                         int repetitionRequirement, int bonusPoints,
                         int timesCompleted = 0)
        : base(goalName, goalDesc, points)
    {
        _repetitionRequirement = repetitionRequirement;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _timesCompleted++;

        if (IsComplete())
        {
            return GetPoints() + _bonusPoints;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _repetitionRequirement;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public int GetRepetitionRequirement()
    {
        return _repetitionRequirement;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{base.GetStringRepresentation()}|{_repetitionRequirement}|{_bonusPoints}|{_timesCompleted}";
    }
}
