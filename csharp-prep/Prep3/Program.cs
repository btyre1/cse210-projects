using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 200);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("\nWhat is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!\n");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            } 
        } 
        
    }
}