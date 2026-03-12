using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
    }

    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;

        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Response: {_entryText}");
        }
    }

    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }

        public void SaveToFile(string filename)
        {
            
        }

        public void LoadFromFile(string filename)
        {
        }
    }

    public class PromptGenerator
    {
        private List<string> _prompts;

        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "How did you find Christ in your life today?",
                "How did you embody the teachings of Christ in your actions today?",
                "Describe a challenge you faced and how you overcame it.",
                "What is something new you learned today?",
                "Write about a moment that made you smile."
            };
        }
    }

}