public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather: {_weatherForecast}";
    }
    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\n{base.GetShortDescription()}";
    }
}