using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a list of scriptures
        List<Scripture> scriptures = GetScripture();

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Random random = new Random();

        // Choose a random scripture from the list
        Scripture randomScripture = scriptures[random.Next(scriptures.Count)];

        // Display the scriptures
        Console.WriteLine(randomScripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

        // Loop until all words are hidden or user quits
        while (!randomScripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            
            // Hide a few random words and display the scripture again
            randomScripture.HideRandomWords(3); // Adjust the number of words to hide as needed
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        }

        Console.WriteLine("Program ended.");
    }

    static List<Scripture> GetScripture()
    {
        List<Scripture> scriptures = new List<Scripture>();

        // Add predefined scriptures
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        return scriptures;
    }
}

