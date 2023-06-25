using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] tablica = GenerujLosowaTablice(10);

        Console.WriteLine("Zawartość tablicy:");
        WypiszTabliceOdTylu(tablica);
    }

    public static int[] GenerujLosowaTablice(int rozmiar)
    {
        int[] tablica = new int[rozmiar];
        Random random = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = random.Next(1, 100); // Wypełnij tablicę losowymi wartościami, zakres: 1-100
        }

        return tablica;
    }

    public static void WypiszTabliceOdTylu(int[] tablica)
    {
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}
