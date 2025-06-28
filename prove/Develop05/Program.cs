// Exceed Requirements: I added a leveling system based on total points.
// I also added a variety of titles that correspond to the level of the user. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string response = "";
        int totalPoints = 0;
        List<Goal> goals = new List<Goal>();

        while (response != "6")
        {
            Console.WriteLine($"\nYou have {totalPoints} points.\nLevel {GetLevel(totalPoints)} - {GetTitle(GetLevel(totalPoints))}\n");
            Console.Write("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            response = Console.ReadLine();

            if (response == "1")
            {
                Console.Write("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    goals.Add(simpleGoal);
                }
                else if (goalType == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    goals.Add(eternalGoal);
                }
                else if (goalType == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int frequency = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, frequency, 0);
                    goals.Add(checklistGoal);
                }
            }
            else if (response == "2")
            {
                Console.WriteLine("The goals are:");
                int i = 0;
                foreach (Goal goal in goals)
                {
                    i++;
                    if (goal.IsComplete())
                    {
                        Console.WriteLine($"{i}. [X] {goal.DisplayGoal()}");
                    }
                    else
                    {
                        Console.WriteLine($"{i}. [ ] {goal.DisplayGoal()}");
                    }
                }
            }
            else if (response == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                SaveGoals(filename, goals, totalPoints);
            }
            else if (response == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                totalPoints = LoadGoals(filename, goals);
            }
            else if (response == "5")
            {
                Console.WriteLine("The goals are:");
                int i = 0;

                foreach (Goal goal in goals)
                {
                    i++;
                    Console.WriteLine($"{i}. {goal.GetName()}");
                }

                int previousLevel = GetLevel(totalPoints);
                Console.Write("Which goal did you accomplish? ");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;

                if (goalIndex >= 0 && goalIndex < goals.Count)
                {
                    Goal selectedGoal = goals[goalIndex];
                    int pointsEarned = selectedGoal.RecordEvent();
                    totalPoints += pointsEarned;

                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {totalPoints} points.");
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }

                int newLevel = GetLevel(totalPoints);

                if (newLevel > previousLevel)
                {
                    Console.WriteLine($"🎉 You leveled up! You are now Level {newLevel}!");
                }
            }
            else
            {
                break;
            }
        }
    }
    static void SaveGoals(string filename, List<Goal> goals, int totalPoints)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(totalPoints);
            foreach (Goal g in goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }
    static int LoadGoals(string filename, List<Goal> goals)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        int totalPoints = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(",");

            string type = parts[0];

            if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int frequency = int.Parse(parts[5]);
                int timesCompleted = int.Parse(parts[6]);

                goals.Add(new ChecklistGoal(name, description, points, bonus, frequency, timesCompleted));
            }
            else if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                goals.Add(new EternalGoal(name, description, points));
            }
        }
        Console.WriteLine("Goals loaded successfully!");
        return totalPoints;
    }
    static int GetLevel(int totalPoints)
    {
        return (totalPoints / 100) + 1;
    }
    static string GetTitle(int level)
    {
        if (level >= 25)
        {
            return "👑 Ultimate Life Leveler";
        }
        else if (level >= 20)
        {
            return "🏆 Legendary Goal Crusher";
        }
        else if (level >= 15)
        {
            return "🏅 Elite Task Slayer";
        }
        else if (level >= 10)
        {
            return "💪 Disciplined Achiever";
        }
        else if (level >= 5)
        {
            return "🌱 Newbie Goal Seeker";
        }
        else
        {
            return "🔰 Beginner";
        }
    }
}