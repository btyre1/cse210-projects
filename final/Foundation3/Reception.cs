public class Recpetion : Event
{
    private string _rsvpEmail;

    public Recpetion(string title, string description, DateOnly date, TimeOnly time, Address address, string rspvEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rspvEmail;
    }
}