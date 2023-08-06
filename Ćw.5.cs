using System;

namespace PotegowanieProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int n;
            int result;

            while (true)
            {
                Console.Write("Podaj liczbę naturalną x: ");
                string xInput = Console.ReadLine();

                if (int.TryParse(xInput, out x) && x >= 0)
                    break;

                Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę naturalną.");
            }

            while (true)
            {
                Console.Write("Podaj wykładnik n (całkowitą nieujemną): ");
                string nInput = Console.ReadLine();

                if (int.TryParse(nInput, out n) && n >= 0)
                    break;

                Console.WriteLine("Nieprawidłowa wartość. Podaj wartość całkowitą nieujemną.");
            }

            // Obliczenie potęgi iteracyjnie
            result = x;
            for (int i = 1; i < n; i++)
            {
                int sum = x;
                for (int j = 1; j < x; j++)
                {
                    sum += x;
                }
                result = sum;
            }

            // Wyświetlenie wyniku
            Console.WriteLine($"Wynik obliczeń: {result}");

            // Wykorzystanie funkcji bibliotecznej do porównania wyników
            int libraryResult = (int)Math.Pow(x, n);
            Console.WriteLine($"Wynik z funkcji bibliotecznej: {libraryResult}");

            // Porównanie wyników
            if (result == libraryResult)
                Console.WriteLine("Wyniki są zgodne.");
            else
                Console.WriteLine("Wyniki nie są zgodne.");

        }
    }
}

