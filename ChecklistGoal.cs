class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints)
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _requiredCount)
        {
            _currentCount++;
            Console.WriteLine($"Progress recorded for '{_name}'. You earned {_points} points.");

            if (_currentCount == _requiredCount)
            {
                Console.WriteLine($"Congratulations! '{_name}' completed! You earned {_bonusPoints} bonus points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _requiredCount;
    }

    public override string DisplayStatus()
    {
        return IsComplete() ? $"[X] {_name} (Completed)" : $"[ ] {_name} ({_currentCount}/{_requiredCount})";
    }
}