using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] tablica = GenerujLosowaTablice(10);

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
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

    public static void WypiszTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.WriteLine(element);
        }
    }

    public static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana;

        do
        {
            zamiana = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    ZamienElementy(tablica, i, i + 1);
                    zamiana = true;
                }
            }

            n--;
        } while (zamiana);
    }

    public static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
    }
}
