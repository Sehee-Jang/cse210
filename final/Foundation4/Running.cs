public class Running : Activity
{
    private float _distance;

    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    public override float GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min): Distance {GetDistance():0.00} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}