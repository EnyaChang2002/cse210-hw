using System;

public class Entry
{
    public string _date;
    public string _promptText;
    //remember to link the _promptText to the PromptGenerator
    public string _entryText;

    public void Display()
    {
        DateTime current = DateTime.Now;
        _date = current.ToShortDateString();
        
        Console.WriteLine(_promptText);
        String response = Console.ReadLine();

        string _entryText = $"Date: {_date} - Prompt {_promptText} ^{response}^ ";
        _entryText = _entryText.Replace("^", "\n");
    }
}