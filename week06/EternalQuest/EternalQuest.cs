public class EternalQuest : Quest
{
    public EternalQuest(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalQuest|{_name}|{_description}|{_points}";
    }
}