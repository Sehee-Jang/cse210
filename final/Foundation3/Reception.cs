public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time,
    Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string getFullDetails()
    {
        return $"{base.getStandardDetails()}\nType: Reciption\nRSVP Email: {_rsvpEmail}";
    }

    public override string getShortDescription()
    {
        return $"Type: Reception\nTitle: {_title}\nDate: {_date}";
    }
}