using System;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type jobs
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}