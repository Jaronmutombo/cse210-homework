public class OneTimeQuest : Quest
{
    private bool _isComplete;

    public OneTimeQuest(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"OneTimeQuest|{_name}|{_description}|{_points}|{_isComplete}";
    }
}