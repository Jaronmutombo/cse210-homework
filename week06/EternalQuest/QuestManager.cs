using System;
using System.Collections.Generic;
using System.IO;

public class QuestManager
{
    private List<Quest> _quests = new List<Quest>();
    private int _score = 0;

    public void DisplayScore()
    {
        Console.WriteLine($"Your Score now is: {_score}");
    }

    public void AddQuest(Quest quest)
    {
        _quests.Add(quest);
    }

    public void ListQuests()
    {
        for (int i = 0; i < _quests.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_quests[i].GetStatus()} {_quests[i].GetDetails()}");
        }
    }

    public void RecordEvent()
    {
        ListQuests();
        Console.Write("Select quest number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _quests.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        int points = _quests[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Quest quest in _quests)
            {
                writer.WriteLine(quest.GetStringRepresentation());
            }
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        _quests.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "OneTimeQuest")
            {
                _quests.Add(new OneTimeQuest(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (parts[0] == "EternalQuest")
            {
                _quests.Add(new EternalQuest(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "CheckListQuest")
            {
                _quests.Add(new CheckListQuest(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }
    }
}
