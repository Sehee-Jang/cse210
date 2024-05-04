public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string entry, string date)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }

    /*
    What are the potential benefits of having a Display method in the Entry class rather than allowing the Journal's display method to display an entry's date and text directly?
        
    */
    public void Display ()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public string GetEntryAsString()
    {
        return $"{_promptText}|{_entryText}|{_date}";
    }
}