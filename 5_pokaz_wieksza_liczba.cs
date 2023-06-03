using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź pierwszą liczbę:");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wprowadź drugą liczbę:");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        if (liczba1 > liczba2)
        {
            Console.WriteLine("Większa liczba to: " + liczba1);
        }
        else if (liczba2 > liczba1)
        {
            Console.WriteLine("Większa liczba to: " + liczba2);
        }
        else
        {
            Console.WriteLine("Obie liczby są takie same.");
        }

        Console.ReadKey();
    }
}