using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment new1 = new Assignment("Charlie", "English");
        Console.WriteLine(new1.GetSummary());

        Console.WriteLine();

        MathAssignemnt new2 = new MathAssignemnt("Ollie", "Math", "2.3", "7-9");
        Console.WriteLine(new2.GetSummary());
        Console.WriteLine(new2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment new3 = new WritingAssignment("Woolie", "Writing", "Art of Warcraft");
        Console.WriteLine(new3.GetSummary());
        Console.WriteLine(new3.GetWritingInformation());
    }
}