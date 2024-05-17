using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;
    private const string LogFilePath = "activity_log.txt";
    

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.Write("\b\b\b\b    \b\b\b\b");
        Console.WriteLine();
        Console.Write("\b");

        // Log the start of the activity
        LogActivity($"Started {_name} activity for {_duration} seconds.");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.Write("\b\b\b\b    \b\b\b\b");
        Console.WriteLine();
        Console.WriteLine($"You've comepleted the {_name} activity for {_duration} seconds.");
        ShowSpinner(5);
        Console.Write("\b\b\b\b    \b\b\b\b");

        // Log the end of the activity
        LogActivity($"Completed {_name} activity for {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void LogActivity(string logEntry)
    {
        using (StreamWriter writer = new StreamWriter(LogFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {logEntry}");
        }
    }

    public static void LoadLog()
    {
        if (File.Exists(LogFilePath))
        {
            string[] logEntries = File.ReadAllLines(LogFilePath);
            Console.WriteLine("Activity Log: ");
            foreach (string logEntry in logEntries)
            {
                Console.WriteLine(logEntry);
            }
        }
        else
        {
            Console.WriteLine("No file found.");
        }
    }

}