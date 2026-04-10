using System;

class Program
{
    static void Main()
    {
        QuestManager manager = new QuestManager();

        while (true)
        {
            Console.Clear();
            manager.DisplayScore();

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Exit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateQuest(manager);
            }
            else if (choice == "2")
            {
                manager.ListQuests();
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                manager.RecordEvent();
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                manager.Save("quests.txt");
            }
            else if (choice == "5")
            {
                manager.Load("quests.txt");
            }
            else if (choice == "6")
            {
                Console.WriteLine("YOU ARE A STAR!");
                break;
            }
        }
    }

    static void CreateQuest(QuestManager manager)
    {
        Console.WriteLine("1. One-Time Quest");
        Console.WriteLine("2. Eternal Quest");
        Console.WriteLine("3. Checklist Quest");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddQuest(new OneTimeQuest(name, desc, points));
        }
        else if (type == "2")
        {
            manager.AddQuest(new EternalQuest(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddQuest(new CheckListQuest(name, desc, points, target, bonus));
        }
    }
}