public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string getFullDetails()
    {
        return $"{base.getStandardDetails()}\nType: Outdoor\nWeather Forecast: {_weatherForecast}";
    }

    public override string getShortDescription()
    {
        return $"Type: Outdoor\nTitle: {_title}\nDate: {_date}";
    }
}