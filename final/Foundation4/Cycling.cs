public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
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
