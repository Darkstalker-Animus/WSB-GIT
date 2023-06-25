using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n;

        Console.Write("Podaj liczbę n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Nieprawidłowa wartość n. Podaj liczbę całkowitą nieujemną: ");
        }

        Console.WriteLine($"Pary liczb naturalnych o sumie {n}:");
        WypiszParyLiczb(n);
    }

    public static void WypiszParyLiczb(int n)
    {
        for (int i = 0; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine($"({i}, {j})");
        }
    }
}

