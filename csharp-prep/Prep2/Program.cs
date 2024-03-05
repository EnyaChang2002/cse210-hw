using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inputFromUser = Console.ReadLine();
        int grade = int.Parse(inputFromUser);

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congradulation, you passed the test!");
        }
        else
        {
            Console.WriteLine("You failed the test.");
        }

        Console.WriteLine($"Your grade is {letter}.");
    }
}