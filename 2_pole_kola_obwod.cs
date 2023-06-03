using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź pole koła:");
        double poleKola = Convert.ToDouble(Console.ReadLine());

        double promien = Math.Sqrt(poleKola / Math.PI);
        double obwod = 2 * Math.PI * promien;

        Console.WriteLine("Obwód koła wynosi: " + obwod);

        Console.ReadKey();
    }
}