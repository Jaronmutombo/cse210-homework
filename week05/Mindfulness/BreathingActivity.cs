public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by breathing slowly.")
    {
    }

    public void Run()
    {
        StartActivity();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountdown(4);
            Console.WriteLine();
        }

        EndActivity();
    }
}