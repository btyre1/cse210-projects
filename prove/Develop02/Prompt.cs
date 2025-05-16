public class Prompt        
{
    public List<string> _prompts = new List<string> {"If I had one thing I could do over today, what would it be?", "What was the best part of my day?", "Who was the most interesting person I interacted with today?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "What is one thing I learned today?", "What am I grateful for right now?", "How did I show kindness today?", "What made me smile today?"};

    public string GeneratePrompt()
    {       
        Random random = new Random();
        int _index = random.Next(_prompts.Count);
        string _prompt = _prompts[_index];

        return _prompt;
    }
}