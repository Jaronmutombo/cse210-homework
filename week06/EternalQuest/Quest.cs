using System;

public class Quest
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Quest(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetails()
    {
        return $"{_name}: {_description}";
    }

    public virtual string GetStatus()
    {
        return IsComplete() ? "[X]" : "[ ]";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}