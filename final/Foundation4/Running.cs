public class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return base.GetDistance();
    }
    public override double GetSpeed()
    {
        return base.GetSpeed();
    }
    public override double GetPace()
    {
        return base.GetPace();
    }
}