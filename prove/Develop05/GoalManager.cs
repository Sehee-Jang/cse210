using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;
using System.Runtime;

public class GoalManager
{
    // Attributes
    private List<Goal> _goals;
    private int _score;
    private int _level;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1; // Start at level 1
    }

    // Methods
    public void Start()
    {
        DisplayMenu();
    }

    // Print the current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou are at Level {_level} with {_score} points.");
    }
    public void CalculateLevel()
    {
        _level = _score / 100 + 1; // Every 100 points advances a level
    }
    public void DisplayMenu()
    {
        while (true)    // Loop until the player chooses to quit
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                Console.Write("Select a choice from the menu: ");
            }
            Console.WriteLine();

            switch (choice) // Handle the player's choice
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();

        int goalType;
        while (true)    // Validate input for goal type
        {
            Console.Write("Which type of goal would you like to create? ");
            if (int.TryParse(Console.ReadLine(), out goalType) && goalType >= 1 && goalType <= 3)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        int points;
        while (true)     // Validate input for points
        {
            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out points))
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid nubmer.");
        }

        switch (goalType)    // Create the appropriate goal based on the type
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                int target;
                while (true)     // Validate input for target completions
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    if (int.TryParse(Console.ReadLine(), out target))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a valid number");
                }

                int bonus;
                while (true)     // Validate input for bonus points
                {
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    if (int.TryParse(Console.ReadLine(), out bonus))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a valid number");
                }
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid answer.");
                break;
        }
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)   // Loop through the goals
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");  // Print each goal's short name
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        int index = 1;
        foreach (var goal in _goals)     // Loop through the goals
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";   // Determine the completion status
            Console.WriteLine($"{index}. {status} {goal.GetDetailsString()}");  // Print each goal's details
            index++;
        }
        Console.WriteLine();
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);
            file.WriteLine(_level);
            foreach (var goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader file = new StreamReader(filename))
            {
                _score = int.Parse(file.ReadLine());
                _level = int.Parse(file.ReadLine());
                _goals = new List<Goal>();
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string[] goalDetails = parts[1].Split(',');

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]));
                            if (bool.Parse(goalDetails[3])) simpleGoal.RecordEvent();
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2])));
                            break;
                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]), int.Parse(goalDetails[4]), int.Parse(goalDetails[3]));
                            for (int i = 0; i < int.Parse(goalDetails[5]); i++)
                            {
                                checklistGoal.RecordEvent();
                            }
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        int goalIndex;
        while (true)
        {
            Console.Write("Which goal did you accomplish? ");
            if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
            {
                goalIndex--;
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }

        Goal goal = _goals[goalIndex];
        goal.RecordEvent();
        int pointsEarned = goal.GetPoints();
        _score += pointsEarned;

        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
            _score += checklistGoal.GetBonus();
            Console.WriteLine($"\nCongratulations! You have earned {pointsEarned + checklistGoal.GetBonus()} points!");
        }
        else
        {
            Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
        }

        CalculateLevel(); // Calculate the level after earning points

        Console.WriteLine($"You now have {_score} points abd are at Level {_level}.");
    }
}