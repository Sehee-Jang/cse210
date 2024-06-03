public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    // List the title, description, date, time, and address
    public virtual string getStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    // List all of the above, plus type of event and information specific to that event type
    public virtual string getFullDetails()
    {
        return getStandardDetails();
    }

    // List the type of event, title, and the date    public abstract string getShortDescription()
    public virtual string getShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date}";
    }
}