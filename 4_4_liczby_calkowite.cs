using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź liczbę a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadź liczbę b:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadź liczbę c:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadź liczbę d:");
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            int x = (a * d) + (b * c);
            int y = b * d;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        Console.ReadKey();
    }
}