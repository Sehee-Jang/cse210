using System.Dynamic;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    // List the title, description, date, time, and address
    public abstract string getStandardDetails();

    // List all of the above, plus type of event and information specific to that event type
    public abstract string getFullDetails();

    // List the type of event, title, and the date    public abstract string getShortDescription()
    public abstract string getShortDescription();
}