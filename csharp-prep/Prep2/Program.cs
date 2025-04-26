using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int grade = int.Parse(gradePercent);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("\nCongradulations, you passed the class!\n");
        }
        else
        {
            Console.WriteLine("\nYou failed the class, study hard and try again.\n");
        }
    }
}