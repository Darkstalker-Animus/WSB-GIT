using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n, k;

        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        int m = ObliczWartosc(n, k);

        Console.WriteLine("Wartość m = (n! - k!) / k! wynosi: " + m);
    }

    public static int ObliczWartosc(int n, int k)
    {
        int nSilnia = ObliczSilnie(n);
        int kSilnia = ObliczSilnie(k);

        return (nSilnia - kSilnia) / kSilnia;
    }

    public static int ObliczSilnie(int liczba)
    {
        int silnia = 1;

        for (int i = 1; i <= liczba; i++)
        {
            silnia *= i;
        }

        return silnia;
    }
}






