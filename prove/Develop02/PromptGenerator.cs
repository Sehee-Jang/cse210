public class PromptGenerator
{
    public List<String> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What happened today? ",
            "What was the best thing that happened today? ",
            "What was the worst thing that happened today? ",
            "What was the most interesting thing I saw or heard today? ",
            "What was the most challenging thing I faced today? ",
            "What am I grateful for today? ",
            "What did I learn today? "
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}