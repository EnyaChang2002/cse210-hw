using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
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

        Console.WriteLine("Get as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        Console.WriteLine();
        ShowCountDown(5);
        
        GetListFromUser();
        
        DisplayEndingMessage();
        Console.Clear();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int ranP = random.Next(1, _prompts.Count);
        Console.WriteLine($"---{_prompts[ranP]}---");  
    }
    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        string ans = Console.ReadLine();
        _count = 0;
        while (ans != "")
        {
            ans = Console.ReadLine();
            list.Add(ans);
            _count++;
        }
        //I don't know why is this returning a list.
        return list;
    }
}