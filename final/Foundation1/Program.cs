using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Video1", "Someone1", 97);
        v1.AddComment("user1", "Great Video!");
        v1.AddComment("user2", "Interesting video, I gave it a like.");
        v1.AddComment("user3", "I don't think I agree.");
        v1.AddComment("user4", "Absolutely hilarious!");
        videos.Add(v1);

        Video v2 = new Video("Video2", "Someone2", 245);
        v2.AddComment("userbrad1202", "I couldn't stop laughing at 5:02.");
        v2.AddComment("usergal5", "I just subscribed, nice vid.");
        v2.AddComment("userguydude", "Bro I need my friends to watch this.");
        videos.Add(v2);

        Video v3 = new Video("Top 10 Travel Destinations", "WanderWorld", 603);
        v3.AddComment("Emma", "Adding all of these to my list!");
        v3.AddComment("James", "Love the editing!");
        v3.AddComment("Zara", "Where's Iceland though?");
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.DisplayInfo();
        }
    }
}