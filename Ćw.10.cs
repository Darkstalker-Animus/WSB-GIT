using System;

namespace LastDigitOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę naturalną: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int ostatniaCyfra = liczba % 10;

            Console.WriteLine("Ostatnia cyfra liczby " + liczba + " to " + ostatniaCyfra + ".");
        }
    }
}
