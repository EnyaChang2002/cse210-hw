using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
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

        int turns = _duration / 5;
        
        for (int i = 0; i < turns; i ++)
        {
            Console.Write("Breath in...");
            ShowCountDown(2);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
        Console.Clear();
    }
}