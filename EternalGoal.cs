class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded progress for '{_name}' and earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string DisplayStatus()
    {
        return $"[∞] {_name} (Repeatable)";
    }
}