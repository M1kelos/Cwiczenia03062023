using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź długość pierwszego boku trójkąta:");
        double bok1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź długość drugiego boku trójkąta:");
        double bok2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź długość trzeciego boku trójkąta:");
        double bok3 = Convert.ToDouble(Console.ReadLine());

        if (bok1 == bok2 && bok2 == bok3)
        {
            Console.WriteLine("Podane boki tworzą trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Podane boki nie tworzą trójkąta równobocznego.");
        }

        Console.ReadKey();
    }
}