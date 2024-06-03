public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time,
    Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Reciption\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {_title}\nDate: {_date}";
    }
}