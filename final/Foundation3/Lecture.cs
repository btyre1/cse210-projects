public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public override string GetShortDescription()
    {
        return $"Event Type: Lecture\n{base.GetShortDescription()}";
    }
}