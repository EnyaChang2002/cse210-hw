using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Events");
        Console.WriteLine("  6. Quit");
        Console.WriteLine("Select a choive from the menu: ");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void ListGoalsName()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            string info = _goals[i].GetStringRepresentation();
            string[] words = info.Split("@");
            
            Console.WriteLine($"{i + 1}. {words[1]}");
        }
    }
    public void ListGoalsDetails()
    {
        Console.WriteLine("The goals are: ");
        string sentence = "";
        for (int i = 0; i < _goals.Count; i++)
        {
            string info = _goals[i].GetStringRepresentation();
            string[] words = info.Split("@");
            
            string check = "";
            if (_goals[i].IsComplete())
            {
                check = "V";
            }
            else if (!(_goals[i].IsComplete()))
            {
                check = "  ";
            }

            if (words.Length > 5)
            {
                sentence = $"{i + 1}. [{check}] {words[1]} ({words[2]}) -- Curremtly Completed: {words[4]}/{words[5]}";
            }
            else
            {
                sentence = $"{i + 1}. [{check}] {words[1]} ({words[2]})";
            }
            Console.WriteLine(sentence);
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("What type of Goal would you like to create?");
        string goalType = Console.ReadLine();
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        string points = Console.ReadLine();

        if (goalType == "1")
        {
            //Simple Goal
            SimpleGoal newS = new SimpleGoal(name, description, points);
            _goals.Add(newS);
        }
        else if (goalType == "2")
        {
            //Eternal Goal
            EternalGoal newG = new EternalGoal(name, description, points);
            _goals.Add(newG);
        }
        else if (goalType == "3")
        {
            //Checklist Goal
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            string stimes = Console.ReadLine();
            int times = int.Parse(stimes);
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            string sbonus = Console.ReadLine();
            int bonus = int.Parse(sbonus);
            ChecklistGoal newC = new ChecklistGoal(name, description, points, times, bonus);
            _goals.Add(newC);
        }

    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        string ans = Console.ReadLine();
        int num = int.Parse(ans);
        string sscore = _goals[num - 1].RecordEvent();
        _score += int.Parse(sscore);
        /*
        for (int i = 0; i < _goals.Count; i++)
        {
            int number = i;
            string snum = number.ToString();
            if (ans == snum)
            {
                int num = int.Parse(ans);
                string sscore = _goals[num].RecordEvent();
                _score += int.Parse(sscore);
            }
        }
        */
        /*
        int number = i;
        string snum = number.ToString();
        if (ans == snum)
        {
            int num = int.Parse(ans);
            string sscore = _goals[num].RecordEvent();
            score += int.Parse(sscore);
        }
        */
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            for (int i = 0; i < _goals.Count; i++)
            {
                
                outputFile.WriteLine($"{_goals[i].GetStringRepresentation()}");
            }
        }

    }
    public void LoadGoals()
    {
        _goals.Clear();
        _score = 0;
        Console.WriteLine("What is the filenamme for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("@");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal newS = new SimpleGoal(parts[1], parts[2], parts[3]);
                if (parts[4] == "True")
                {
                    bool complete = true;
                    newS.SetComplete(complete);
                }
                else if (parts[4] == "False")
                {
                    bool complete = false;
                    newS.SetComplete(complete);   
                }
                _goals.Add(newS);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal newE = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(newE);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                int amount = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                ChecklistGoal newC = new ChecklistGoal(parts[1], parts[2], parts[3], target, bonus);
                newC.SetAmount(amount);
                _goals.Add(newC);
            }
            else
            {
                //this is the first line, where scores are
                int score = int.Parse(parts[0]);
                _score = score;
            }
        }
    }

}