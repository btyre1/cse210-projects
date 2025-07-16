public class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }
    public virtual double GetDistance()
    {
        return 52;
    }
    public virtual double GetSpeed()
    {
        return 52;
    }
    public virtual double GetPace()
    {
        return 52;
    }
    public virtual string GetSummary()
    {
        return "2";
    }
}