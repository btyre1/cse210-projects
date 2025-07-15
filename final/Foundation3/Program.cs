using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Event> events = new List<Event>();

        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Event lecture = new Lecture("Understanding AI", "An in-depth lecture on AI.", "Aug 10, 2025", "2:00 PM", address1, "Dr. Smith", 100);
        events.Add(lecture);

        Address address2 = new Address("456 Sunset Blvd", "Phoenix", "AZ", "USA");
        Event reception = new Reception("Tech Mixer", "Startup networking reception.", "Sept 1, 2025", "6:30 PM", address2, "rsvp@tech.com");
        events.Add(reception);

        Address address3 = new Address("789 Forest Rd", "Portland", "OR", "USA");
        Event outdoor = new OutdoorGathering("Summer Concert", "Enjoy live music in the park.", "July 20, 2025", "5:00 PM", address3, "Sunny, 75°F");
        events.Add(outdoor);

        foreach (Event ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 50));
        }
    }
}