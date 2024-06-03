public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor\nWeather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor\nTitle: {_title}\nDate: {_date}";
    }
}