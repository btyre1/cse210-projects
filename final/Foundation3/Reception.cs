public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rspvEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rspvEmail;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvpEmail}";
    }
    public override string GetShortDescription()
    {
        return $"Event Type: Reception\n{base.GetShortDescription()}";
    }
}