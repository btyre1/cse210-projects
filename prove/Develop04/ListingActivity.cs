class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>() { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private Random _random = new Random();
    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void PerformActivity()
    {
        Console.Write($"List as many responses you can to the following prompt:\n --- {GetRandomPrompt()} ---\nYou may begin in: ");
        DisplayCountDown(5);
        Console.WriteLine();
        int i = 0;

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            i++;
        }

        Console.Write($"You listed {i} items!");
    }
}