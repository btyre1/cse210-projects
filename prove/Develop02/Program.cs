// Exceed Requirements:
// - Added a title that the user gives to each journal entry and updated the rest of the program to include titles.
// - Added a daily motivational quote when the app starts to encourage consistent journaling.

using System;
using System.Reflection;

class Program
{
    static void PrintMotivationMessage()
    {
        List<string> messages = new List<string> { "Every word you write today is a step toward self-discovery.", "Reflecting even for a minute today strengthens your tomorrow.", "You're doing great. Let your thoughts breathe through writing.", "Small entries lead to big insights. Keep going!", "This moment matters. Capture it." };
        Random random = new Random();
        int index = random.Next(messages.Count);

        Console.WriteLine($"\n✨ {messages[index]}\n");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Journal Program!");
        PrintMotivationMessage();
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        string menuResponse = "";

        while (menuResponse != "5")
        {
            Console.Write("Please select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            menuResponse = Console.ReadLine();

            if (menuResponse == "1")
            {
                Console.Write("Title of your entry: ");
                string title = Console.ReadLine();

                string randomPrompt = prompt.GeneratePrompt();
                Console.Write($"{randomPrompt}\n> ");

                Entry entry = new Entry();
                entry._text = Console.ReadLine();
                entry._prompt = randomPrompt;
                entry._date = DateTime.Today.ToString("MM/dd/yyyy");
                entry._title = title;

                journal.AddEntry(entry);
            }
            else if (menuResponse == "2")
            {
                journal.PrintJournal();
            }
            else if (menuResponse == "3")
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.Load(fileName);
            }
            else if (menuResponse == "4")
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.Save(fileName);
            }
            else if (menuResponse == "5")
            {
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1-5.");
            }
        }
    }
}