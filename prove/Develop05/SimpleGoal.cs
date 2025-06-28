public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }

        return 0;
    }
}