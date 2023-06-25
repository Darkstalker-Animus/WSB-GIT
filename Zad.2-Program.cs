using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] tablica = GenerujLosowaTablice(10);

        Console.WriteLine("Zawartość tablicy:");
        WypiszTablice(tablica);

        int najmniejszy = ZnajdzNajmniejszyElement(tablica);
        int najwiekszy = ZnajdzNajwiekszyElement(tablica);

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + najwiekszy);
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

    public static int ZnajdzNajmniejszyElement(int[] tablica)
    {
        int najmniejszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }
        }

        return najmniejszy;
    }

    public static int ZnajdzNajwiekszyElement(int[] tablica)
    {
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > najwiekszy)
            {
                najwiekszy = tablica[i];
            }
        }

        return najwiekszy;
    }
}

