using System;

class Program
{
    static void Main(string[] args)
    {
        string ans = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            ans = Console.ReadLine();
            if (ans == "1")
            {
                //breathing
                Console.Clear();
                string name = "Breathing";
                string description = "";
                BreathingActivity newB = new BreathingActivity(name, description);
                newB.Run();
            }
            else if (ans == "2")
            {
                //reflecting
                Console.Clear();
                string name = "Reflecting";
                string description = "";
                List<string> listP = new List<string>();
                listP.Add("Think of a time when you stood up for someone else.");
                listP.Add("Think of a time when you did something really difficult.");
                listP.Add("Think of a time when you helped someone in need.");
                listP.Add("Think of a time when you did something truly selfless.");
                List<string> listQ = new List<string>();
                listQ.Add("Why was this experience meaningful to you?");
                listQ.Add("Have you ever done anything like this before?");
                listQ.Add("How did you get started?");
                listQ.Add("How did you feel when it was complete?");
                listQ.Add("What made this time different than other times when you were not as successful?");
                listQ.Add("What is your favorite thing about this experience?");
                listQ.Add("What could you learn from this experience that applies to other situations?");
                listQ.Add("What did you learn about yourself through this experience?");
                listQ.Add("How can you keep this experience in mind in the future?");
                ReflectingActivity newR = new ReflectingActivity(name, description, listP, listQ);
                newR.Run();
            }
            else if (ans == "3")
            {
                //listing
                Console.Clear();
                string name = "Listing";
                string description = "";
                List<string> listP = new List<string>();
                listP.Add("Who are people that you appreciate?");
                listP.Add("What are personal strengths of yours?");
                listP.Add("Who are people that you have helped this week?");
                listP.Add("When have you felt the Holy Ghost this month?");
                listP.Add("Who are some of your personal heroes?");
                ListingActivity newL = new ListingActivity(name, description, listP);
                newL.Run();
            }
            else if (ans == "4")
            {
                System.Environment.Exit(1);
            }
        } while (ans != "4");
        
    }
}