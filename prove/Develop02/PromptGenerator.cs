using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("What is the one thing you wished you had finished today?");
        _prompts.Add("Where is the most memorable place you went to today?");
        Random ran = new Random();
        int num = ran.Next(0, _prompts.Count);

        string chosenMessage = _prompts[num];
        return chosenMessage;
    }
}