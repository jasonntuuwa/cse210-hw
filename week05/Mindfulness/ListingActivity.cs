using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you recognize positive aspects of your life by challenging you to list several things in a given category.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You will have a few seconds to think of items...");
        ShowCountDown(5);

        Console.WriteLine("Start listing items!");
        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entry))
            {
                items.Add(entry);
            }
        }

        return items;
    }
}