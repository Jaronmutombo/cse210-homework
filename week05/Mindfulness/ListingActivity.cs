using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped this week?"
    };

    public ListingActivity()
        : base("Listing", "List as many things as you can.")
    {
    }

    public void Run()
    {
        StartActivity();
        Random rand = new Random();

        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        ShowCountdown(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}