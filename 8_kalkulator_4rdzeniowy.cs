using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź pierwszą liczbę:");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź drugą liczbę:");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wybierz numer działania:");
        Console.WriteLine("1 - Dodawanie");
        Console.WriteLine("2 - Odejmowanie");
        Console.WriteLine("3 - Mnożenie");
        Console.WriteLine("4 - Dzielenie");
        int numerDzialania = Convert.ToInt32(Console.ReadLine());

        double wynik = 0;

        switch (numerDzialania)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Dzielenie przez zero!");
                    Console.WriteLine("Wynik: {0}/0", liczba1);
                    Console.ReadKey();
                    return;
                }
                break;
            default:
                Console.WriteLine("Niepoprawny numer działania.");
                Console.ReadKey();
                return;
        }

        Console.WriteLine("Wynik: " + wynik);

        Console.ReadKey();
    }
}