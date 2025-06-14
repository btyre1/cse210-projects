using System.Net;
using System.Runtime.InteropServices;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>() { "Think of a time you did something really difficult.", "Think of a time when you stood up for someone else.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string>() { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    private Random _random = new Random();

    public ReflectingActivity()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void PerformActivity()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine($"Consider the following prompt:\n\n --- {prompt} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("Now ponder each of the following questions as they are related to this experience.\nYou may begin in: ");
        DisplayCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            TimeSpan timeLeft = endTime - DateTime.Now;

            if (timeLeft.TotalSeconds > 13)
            {
                Console.Write($"\n> {GetRandomQuestion()} ");
                DisplaySpinner(13);
            }
            else
            {
                Console.Write("\nJust relax...");
                DisplaySpinner((int)timeLeft.TotalSeconds);
                break;
            }
        }
    }
}