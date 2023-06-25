using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Potegowanie(2, 3)); // 2 do potęgi 3
        Console.WriteLine(Potegowanie(5, 2)); // 5 do potęgi 2
    }

    public static int Potegowanie(int podstawa, int wykladnik)
    {
        int wynik = 1;

        for (int i = 0; i < wykladnik; i++)
        {
            wynik *= podstawa;
        }

        return wynik;
    }
}