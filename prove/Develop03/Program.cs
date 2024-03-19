using System;
using System.ComponentModel;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Reference newR = new Reference("Alma", 3, 9);
        string text = "And it came to pass that whosoever did mingle his seed with that of the Lamanites did bring the same curse upon his seed.";
        Scripture newS = new Scripture(newR, text);
        newR.GetDisplayText();
        
        Console.WriteLine($"{newR.GetDisplayText()} {text}");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        do
        {
            string ans = Console.ReadLine();

            if (ans == "")
            {
                Console.Clear();
                 //generate random numbers to hide
                string[] split_text = text.Split();
                Random newRan = new Random();
                int ran1 = newRan.Next(0, split_text.Length);
                int ran2 = newRan.Next(0, split_text.Length);
                int ran3 = newRan.Next(0, split_text.Length);
                 //Hide numbers
                newS.HideRandomWords(ran1);
                newS.HideRandomWords(ran2);
                newS.HideRandomWords(ran3);
                //display the scripture
                Console.WriteLine($"{newR.GetDisplayText()} {newS.GetDisplayText()}");
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                bool quit = newS.IsCompletelyHidden();

                if (quit)
                {
                    System.Environment.Exit(1);
                }
            }
            else if (ans == "quit")
            {
                System.Environment.Exit(1);
            }
        } while (newS.IsCompletelyHidden() == false);
    }
}