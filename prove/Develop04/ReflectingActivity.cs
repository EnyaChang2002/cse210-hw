using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string con = Console.ReadLine();
        if (con == "")
        {
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in:");
            ShowCountDown(5);

            Console.Clear();

            int turns = _duration / 4;

            for (int i = 0; i < turns; i++)
            {
                DisplayQuestions();
            }

            DisplayEndingMessage();
            Console.Clear();
        }


    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int ranP = random.Next(1, _prompts.Count);
        return _prompts[ranP];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int ranP = random.Next(1, _questions.Count);
        return _questions[ranP];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQuestions()
    {
        Console.Write($">{GetRandomQuestion()}");
        ShowSpinner(4);
        Console.WriteLine();
    }
}