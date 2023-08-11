using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static int CountPrimeDivisors(int n)
    {
        if (n <= 5)
            return 0;

        int count = 0;
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0 && IsPrime(i))
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        int number = 36;
        int primeDivisorCount = CountPrimeDivisors(number);

        Console.WriteLine($"Liczba pierwszych dzielników liczby {number}: {primeDivisorCount}");
    }
}
