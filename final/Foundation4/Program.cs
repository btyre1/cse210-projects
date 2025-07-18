using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = new List<Activity>
        {
            new Running("07 Jul 2025", 30, 3.0),
            new Cycling("08 Jul 2025", 45, 12.0),
            new Swimming("09 Jul 2025", 40, 50)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("");
        }
    }
}