public class ChecklistGoal : Goal
{
    // Attributes
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    // Methods
    public override void RecordEvent()
    {
        _amountCompleted++; // Increment the number of completions
    }
    public override bool IsComplete()
    {
        // Return true if the number of completions meets or exceeds the target
        if (_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" - Completed {_amountCompleted}/{_target}";
    }
}