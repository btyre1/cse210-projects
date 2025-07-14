public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateOnly date, TimeOnly time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
}