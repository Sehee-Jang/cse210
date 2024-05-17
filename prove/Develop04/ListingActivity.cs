public class ListingActivity : Activity
{
    // Attributes
    private int _count;
    private List<string> _prompts;

    // Constructor
    public ListingActivity() : base("Listing", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        List<string> itemList = GetListFromUser();
        _count = itemList.Count;
        Console.WriteLine($"You listed {_count} items!\n");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"List as many responses you can to the following prompt:");
        Console.WriteLine($"-- {_prompts[index]} --");
    }

    public List<string> GetListFromUser()
    {
        List<string> itemsList = new List<string>();
        DateTime startTime = DateTime.Now;
        int duration = _duration;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;

            itemsList.Add(item);
        }
        return itemsList;
    }
}