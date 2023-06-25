using System;

public class Program
{
    public static void Main(string[] args)
    {
        int liczba;

        Console.Write("Podaj liczbę naturalną: ");
        while (!int.TryParse(Console.ReadLine(), out liczba) || liczba < 100)
        {
            Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę naturalną zawierającą przynajmniej 3 cyfry: ");
        }

        Console.WriteLine("Kolejne cyfry liczby:");
        WypiszKolejneCyfry(liczba);
    }

    public static void WypiszKolejneCyfry(int liczba)
    {
        while (liczba > 0)
        {
            int cyfra = liczba % 10; // Pobierz ostatnią cyfrę
            Console.WriteLine(cyfra); // Wypisz cyfrę
            liczba /= 10; // Usuń ostatnią cyfrę z liczby
        }
    }
}

