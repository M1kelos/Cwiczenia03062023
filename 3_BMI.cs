using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź swoją masę ciała w kilogramach:");
        double masaCiala = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź swój wzrost w metrach:");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = masaCiala / (wzrost * wzrost);

        Console.WriteLine("Twój współczynnik BMI wynosi: " + bmi);

        Console.ReadKey();
    }
}