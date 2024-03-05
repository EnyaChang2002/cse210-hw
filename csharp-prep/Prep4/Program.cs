using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        
        int inputNum = 0;
        int sum = 0;
        int num = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string stringNum = Console.ReadLine();
            inputNum = int.Parse(stringNum);
            if (inputNum != 0)
            {
                number.Add(inputNum);
            }
        } while (inputNum != 0);

        for (int i = 0; i < number.Count; i++)
        {
            sum = sum + number[i];
        }
        Console.WriteLine($"The sum is: {sum}.");

        int average = sum / number.Count;
        Console.WriteLine($"The average is: {average}.");

        foreach (int i in number)
        {
            if (i > num)
            {
                num = i;
            }
        }
        Console.WriteLine($"The largest number is: {num}");

    }
}