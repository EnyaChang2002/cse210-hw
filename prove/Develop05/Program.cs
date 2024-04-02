using System;

class Program
{
    static void Main(string[] args)
    {
        bool endGame = false;
        GoalManager goal1 = new GoalManager();
        do
        {
            goal1.Start();
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                //Create new Goal
                goal1.CreateGoal();
            }
            else if (choice == "2")
            {
                //List Goals
                goal1.ListGoalsDetails();
            }
            else if (choice == "3")
            {
                //Save Goals
                goal1.SaveGoals();
            }
            else if (choice == "4")
            {
                //Load Goals
                goal1.LoadGoals();
            }
            else if (choice == "5")
            {
                //Record Events
                goal1.ListGoalsName();
                goal1.RecordEvent();
            }
            else if (choice == "6")
            {
                //Quit
                System.Environment.Exit(1);
            }
        } while (endGame == false);
    }
}