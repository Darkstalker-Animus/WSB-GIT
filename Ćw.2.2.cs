using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 10; // n - liczba wylozowanych liczb

        int evenNumbersCount = 0;
        int attempts = 0;
        string result = "";

        while (evenNumbersCount < n)
        {
            int randomNumber = random.Next(-4, 5) * 2;
            attempts++;

            if (evenNumbersCount > 0)
                result += ", ";
            result += randomNumber;
            evenNumbersCount++;
        }

        Console.WriteLine($"Wylosowane liczby parzyste ({n} sztuk): {result}");
        Console.WriteLine($"Liczba prób losowania: {attempts}");
    }
}
