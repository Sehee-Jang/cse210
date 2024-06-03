using System.Data;

public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return (_speed / _length) / 60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min): Distance {GetDistance():0.00} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}