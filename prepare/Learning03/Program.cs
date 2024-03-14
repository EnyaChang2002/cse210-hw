using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction new1 = new Fraction();
        Fraction new2 = new Fraction(6);
        Fraction new3 = new Fraction(6, 7);
        
        Fraction new4 = new Fraction();
        //new4.SetTop(3);
        //new4.SetBottom(4);
        //string top = Console.ReadLine();
        Console.WriteLine(new4.GetFractionString());
        Console.WriteLine(new4.GetDecimalValue());
    }
}