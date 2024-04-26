using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        // Displays the message, "Welcome to the Program!"
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        // Asks for and returns the user's name (as a string)
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        // Asks for and returns the user's favorite number (as an integer)
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int favNum = int.Parse(userInput);

        return favNum;
    }
    static int SquareNumber(int number)
    {
        // Accepts an integer as a parameter and returns that number squared (as an integer)
        int squareNum = number * number;

        return squareNum;
    }
    static void DisplayResult(string name, int squareNum)
    {
        // Accepts the user's name and the squared number and displays them.
        Console.WriteLine($"{name}, the square of your number is {squareNum}.");
    }
}