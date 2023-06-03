using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź współrzędną x punktu P:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź współrzędną y punktu P:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź promień koła r:");
        double r = Convert.ToDouble(Console.ReadLine());

        double odlegloscKwadrat = (x - 0) * (x - 0) + (y - 0) * (y - 0);

        if (odlegloscKwadrat <= r * r)
        {
            Console.WriteLine("Punkt P({0}, {1}) leży w obrębie koła.", x, y);
        }
        else
        {
            Console.WriteLine("Punkt P({0}, {1}) nie leży w obrębie koła.", x, y);
        }

        Console.ReadKey();
    }
}