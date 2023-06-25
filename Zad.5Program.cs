using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] tablica = GenerujLosowaTablice(10);

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWstawianie(tablica);

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

    public static void SortowaniePrzezWstawianie(int[] tablica)
    {
        for (int i = 1; i < tablica.Length; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
        }
    }
}

