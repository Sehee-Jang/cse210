using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,100);

        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}

/*
Stretch Challenge
Keep track of how many guesses the user has made and inform them of it at the end of the game.

After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
*/