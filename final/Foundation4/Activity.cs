public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract float GetDistance();
    public abstract float GetPace();
    public abstract float GetSpeed();
    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_length} min): Distance: {GetDistance():0.00} km, Speed: {GetSpeed} kph, Pace: {GetPace()} min per km";
    }
}