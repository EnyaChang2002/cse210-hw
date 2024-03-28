using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square newS = new Square("blue", 4);
        Console.WriteLine(newS.GetColor());
        Console.WriteLine(newS.GetArea());
        Console.WriteLine();

        Rectangle newR = new Rectangle("yellow", 6, 9);
        Console.WriteLine(newR.GetColor());
        Console.WriteLine(newR.GetArea());
        Console.WriteLine();

        Circle newC = new Circle("orange", 5);
        Console.WriteLine(newC.GetColor());
        Console.WriteLine(newC.GetArea());

        List<Shape> newL = new List<Shape>();
        newL.Add(newS);
        newL.Add(newR);
        newL.Add(newC);

        foreach (Shape shape in newL)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}