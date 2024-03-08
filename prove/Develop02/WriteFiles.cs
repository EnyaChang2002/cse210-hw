using System;
using System.Collections.Generic;

public class WriteFiles
{
    public string _response;
    public string _entry;

    public string ReturnMessage()
    {
        //will be stored in the _entry
        List<string> prompt = new List<string>();
        prompt.Add("Who was the most interesting person I interacted with today?");
        prompt.Add("What was the best part of my day?");
        prompt.Add("What was the strongest emotion I felt today?");
        prompt.Add("What is the one thing you wished you had finished today?");
        prompt.Add("Where is the most memorable place you went to today?");
        Random ran = new Random();
        int num = ran.Next(0, prompt.Count);
        string chosenMessage = prompt[num];
        Console.WriteLine(chosenMessage);

        DateTime current = DateTime.Now;
        String dateText = current.ToShortDateString();
        string message = $"Date: {dateText} - Prompt {chosenMessage}";
        return message;
    }
}