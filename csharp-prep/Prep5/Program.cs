using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            return number;
        }
        static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;
        }
        static void displayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        displayResult(name, squared);
        
    }
        
}