public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {

    }

    // Methods
    public override void RecordEvent()
    {
        // Eternal goals don't have a completion state
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}