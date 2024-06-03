public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override float GetPace()
    {
        return _length / GetDistance();
    }

    public override float GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min): Distance {GetDistance():0.00} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}