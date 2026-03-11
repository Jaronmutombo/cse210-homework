using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Data Analyst";
        job1._company = "Tesla";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Customer Relations Manager";
        job2._company = "Natures Sunshine";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Dalma Ebondo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}