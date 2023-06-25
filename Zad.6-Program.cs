using System;

public class Program
{
    public static void Main(string[] args)
    {
        int x;

        Console.Write("Podaj liczbę x: ");
        while (!int.TryParse(Console.ReadLine(), out x) || x < 0)
        {
            Console.WriteLine("Nieprawidłowa wartość x. Podaj liczbę całkowitą nieujemną: ");
        }

        int n = SprawdzSilnie(x);

        if (n != -1)
        {
            Console.WriteLine($"{x} jest silnią liczby {n}");
        }
        else
        {
            Console.WriteLine($"{x} nie jest silnią żadnej liczby");
        }
    }

    public static int SprawdzSilnie(int x)
    {
        int n = 0;
        int silnia = 1;

        while (silnia <= x)
        {
            if (silnia == x)
            {
                return n;
            }

            n++;
            silnia *= (n + 1);
        }

        return -1;
    }
}

