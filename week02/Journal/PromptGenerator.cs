using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What made me smile today?");
        _prompts.Add("What is something I learned today?");
        _prompts.Add("What challenge did I overcome today?");
        _prompts.Add("Who am I most grateful for right now, and why?");
        _prompts.Add("What is one goal I want to work toward tomorrow?");
        _prompts.Add("What is something I want to remember about today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}