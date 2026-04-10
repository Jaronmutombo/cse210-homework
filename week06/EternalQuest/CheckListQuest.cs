public class CheckListQuest : Quest
{
    private int _target;
    private int _current;
    private int _bonus;

    public CheckListQuest(string name, string description, int points, int target, int bonus, int current = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = current;
    }

    public override int RecordEvent()
    {
        _current++;

        if (_current == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _current >= _target;
    }

    public override string GetDetails()
    {
        return $"{_name}: {_description} ({_current}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListQuest|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_current}";
    }
}