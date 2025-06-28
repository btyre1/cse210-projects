public class ChecklistGoal : Goal
{
    private int _frequency;
    private int _bonus;
    private int _timesCompleted;
    public ChecklistGoal(string name, string description, int points, int bonus, int frequency, int timesCompleted) : base(name, description, points)
    {
        _frequency = frequency;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }
    public override string DisplayGoal()
    {
        return $"{GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_frequency}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_frequency},{_timesCompleted}";
    }
    public override bool IsComplete()
    {
        return _timesCompleted >= _frequency;
    }
    public override int RecordEvent()
    {
        if (_timesCompleted >= _frequency)
        {
            return 0;
        }

        _timesCompleted++;

        if (_timesCompleted == _frequency)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }
}