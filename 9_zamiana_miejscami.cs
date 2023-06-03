using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź wartość zmiennej a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadź wartość zmiennej b:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadź wartość zmiennej c:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Przed zamianą miejscami:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);

        // Zamiana miejscami
        b = b + a;
        a = b - a;
        b = b - a;
        c = c + a;
        a = c - a;
        c = c - a;

        Console.WriteLine("Po zamianie miejscami:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);

        Console.ReadKey();
    }
}