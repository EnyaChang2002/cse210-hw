using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.WriteLine($"What is the magic number? {number}");

        int user = 0;
        do
        {
            Console.Write("What is your guess? ");
            string stringUser = Console.ReadLine();
            user = int.Parse(stringUser);

            if (user > number)
            {
                Console.WriteLine("Lower.");
            }
            else if (user < number)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        } while (user != number);
    }
}