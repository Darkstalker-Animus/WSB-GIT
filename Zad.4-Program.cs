using System;

public class Program
{
    public static void Main(string[] args)
    {
        decimal kwotaPoczatkowa;
        decimal oprocentowanie;
        int liczbaMiesiecy;

        do
        {
            Console.Write("Podaj kwotę początkową wpłacaną na konto oszczędnościowe: ");
        } while (!decimal.TryParse(Console.ReadLine(), out kwotaPoczatkowa) || kwotaPoczatkowa < 0);

        do
        {
            Console.Write("Podaj oprocentowanie konta w skali roku: ");
        } while (!decimal.TryParse(Console.ReadLine(), out oprocentowanie) || oprocentowanie < 0);

        do
        {
            Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        } while (!int.TryParse(Console.ReadLine(), out liczbaMiesiecy) || liczbaMiesiecy < 0);

        decimal kwotaKoncowa = ObliczKwoteZarobiona(kwotaPoczatkowa, oprocentowanie, liczbaMiesiecy);

        Console.WriteLine("Kwota zarobiona na koncie oszczędnościowym (uwzględniając podatek Belki): " + kwotaKoncowa);
    }

    public static decimal ObliczKwoteZarobiona(decimal kwotaPoczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
    {
        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + oprocentowanieMiesieczne), liczbaMiesiecy);
        kwotaKoncowa *= (decimal)(1 - 0.19); // Odjęcie podatku Belki (19%)

        return kwotaKoncowa;
    }
}

