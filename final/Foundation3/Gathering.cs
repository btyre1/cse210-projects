public class Gathering : Event
{
    private string _weatherForecast;

    public Gathering(string title, string description, DateOnly date, TimeOnly time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
}