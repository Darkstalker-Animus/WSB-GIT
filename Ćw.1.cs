using System;

namespace AverageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź pierwszą liczbę: ");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź drugą liczbę: ");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź trzecią liczbę: ");
            double liczba3 = Convert.ToDouble(Console.ReadLine());

            double suma = liczba1 + liczba2 + liczba3;
            double srednia = suma / 3;

            Console.WriteLine("Średnia arytmetyczna wynosi: " + srednia);
        }
    }
}

