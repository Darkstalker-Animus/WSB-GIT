using System;

public class Program
{
    public static void Main(string[] args)
    {
        double x;
        int n;

        Console.Write("Podaj wartość x: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Nieprawidłowa wartość x. Podaj liczbę rzeczywistą: ");
        }

        Console.Write("Podaj liczbę wyrazów szeregu n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Nieprawidłowa wartość n. Podaj liczbę całkowitą nieujemną: ");
        }

        double wynik = SzacujExp(x, n);

        Console.WriteLine("Szacowana wartość funkcji e^x: " + wynik);
    }

    public static double SzacujExp(double x, int n)
    {
        double wynik = 1.0; // Pierwszy wyraz szeregu

        for (int i = 1; i <= n; i++)
        {
            wynik += Math.Pow(x, i) / Silnia(i);
        }

        return wynik;
    }

    public static double Silnia(int liczba)
    {
        if (liczba == 0)
            return 1;

        double wynik = 1;
        for (int i = 1; i <= liczba; i++)
        {
            wynik *= i;
        }

        return wynik;
    }
}
