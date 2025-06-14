using System.Reflection.PortableExecutable;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplaySpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count())
            {
                i = 0;
            }
        }
    }
    public void DisplayCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public int DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($"Welcome to the {_name} Activity.\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }
    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(4);
        Console.WriteLine();
    }
    public void End()
    {
        Console.WriteLine("\n\nWell done!!");
        DisplaySpinner(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        DisplaySpinner(6);
    }
}