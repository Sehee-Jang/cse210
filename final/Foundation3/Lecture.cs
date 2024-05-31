class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {

    }

    public override string getStandardDetails()
    {
        return "{_title}, {_description}, {_date}, {_time}, {_address}";
    }
    public override string getFullDetails()
    {
        return getStandardDetails() + "${_speaker} + {_capacity}";
    }

    public override string getShortDescription()
    {
        return "${_speaker} + {_capacity} + {_title} + {date}";
    }
}