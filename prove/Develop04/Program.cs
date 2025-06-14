// Exceed Requirements: Instead of just having a countdown for the breathing activity, I switched it out with a bar loading animation.
// I also added an additional message and spinner to the breathing and relfecting activites to fill any extra time.


using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string menuResponse = "";

        while (menuResponse.ToLower() != "4")
        {
            Console.Clear();
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
            menuResponse = Console.ReadLine();

            if (menuResponse == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.DisplayStartingMessage();
                activity.Start();
                activity.PerformActivity();
                activity.End();
            }
            else if (menuResponse == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.DisplayStartingMessage();
                activity.Start();
                activity.PerformActivity();
                activity.End();
            }
            else if (menuResponse == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.DisplayStartingMessage();
                activity.Start();
                activity.PerformActivity();
                activity.End();
            }
        }
    }
}