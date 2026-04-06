using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you stood up for someone."
    };

    private List<string> questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "Would you do it again?"
    };

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on your strength.")
    {
    }

    public void Run()
    {
        StartActivity();
        Random rand = new Random();

        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        ShowSpinner(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            ShowSpinner(5);
        }

        EndActivity();
    }
}