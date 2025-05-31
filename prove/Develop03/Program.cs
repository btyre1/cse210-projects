// Exceeding Requirements:
// Loads scriptures from a file (scriptures.txt) and selects one at random.
// Randomly selects from only those words that are not already hidden.
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 4)
            {
                scriptures.Add(new Scripture(parts[3], parts[0], int.Parse(parts[1]), int.Parse(parts[2])));
            }
            else if (parts.Length == 5)
            {
                scriptures.Add(new Scripture(parts[4], parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3])));
            }
        }

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        string response = "";

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords(3);
        }

        Console.Clear();
        scripture.DisplayScripture();
        Console.WriteLine();
    }
}