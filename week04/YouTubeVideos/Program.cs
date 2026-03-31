using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1._title = "Learning C# Basics";
        video1._author = "John Smith";
        video1._length = 600;

        video1._comments.Add(new Comment("Alice", "Great video!"));
        video1._comments.Add(new Comment("Bob", "Very helpful."));
        video1._comments.Add(new Comment("Charlie", "Thanks for explaining."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video();
        video2._title = "Object-Oriented Programming";
        video2._author = "Jane Doe";
        video2._length = 750;

        video2._comments.Add(new Comment("Mike", "Awesome lesson."));
        video2._comments.Add(new Comment("Sarah", "This helped a lot."));
        video2._comments.Add(new Comment("Tom", "Good explanation."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video();
        video3._title = "Lists in C#";
        video3._author = "Code Academy";
        video3._length = 500;

        video3._comments.Add(new Comment("Anna", "Nice tutorial."));
        video3._comments.Add(new Comment("David", "I understand now."));
        video3._comments.Add(new Comment("Emma", "Very clear."));
        videos.Add(video3);

        // Display videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}