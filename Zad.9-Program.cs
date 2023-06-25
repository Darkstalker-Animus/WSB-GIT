using System;

public class Program
{
    public static void Main(string[] args)
    {
        int liczba;

        Console.Write("Podaj liczbę: ");
        while (!int.TryParse(Console.ReadLine(), out liczba))
        {
            Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę całkowitą: ");
        }

        int odwroconaLiczba = OdwrocKolejnoscCyfr(liczba);

        Console.WriteLine("Odwrocona liczba: " + odwroconaLiczba);
    }

    public static int OdwrocKolejnoscCyfr(int liczba)
    {
        int odwroconaLiczba = 0;

        while (liczba > 0)
        {
            int cyfra = liczba % 10; // Pobierz ostatnią cyfrę
            odwroconaLiczba = odwroconaLiczba * 10 + cyfra; // Dodaj cyfrę do odwroconej liczby
            liczba /= 10; // Usuń ostatnią cyfrę z liczby
        }

        return odwroconaLiczba;
    }
}

