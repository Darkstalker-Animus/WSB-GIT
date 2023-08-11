using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź pierwszą liczbę: ");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź drugą liczbę: ");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź numer działania (1-dodawanie, 2-odejmowanie, 3-mnożenie, 4-dzielenie): ");
            int operacja = Convert.ToInt32(Console.ReadLine());

            double wynik = 0;

            if (operacja == 1)
            {
                wynik = liczba1 + liczba2;
            }
            else if (operacja == 2)
            {
                wynik = liczba1 - liczba2;
            }
            else if (operacja == 3)
            {
                wynik = liczba1 * liczba2;
            }
            else if (operacja == 4)
            {
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer operacji.");
                return;
            }

            Console.WriteLine("Wynik: " + wynik);
        }
    }
}

