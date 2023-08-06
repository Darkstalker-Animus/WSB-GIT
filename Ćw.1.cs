using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        try
        {
            Console.Write("Podaj liczbę n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Liczba n musi być większa od zera.");
                return;
            }

            int primesFound = 0;
            int numberToCheck = 2;

            Console.WriteLine($"{n} pierwszych liczb pierwszych:");
            while (primesFound < n)
            {
                if (IsPrime(numberToCheck))
                {
                    Console.WriteLine(numberToCheck);
                    primesFound++;
                }
                numberToCheck++;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Wprowadzono niepoprawne dane. Wprowadź liczbę całkowitą.");
        }
    }
}
