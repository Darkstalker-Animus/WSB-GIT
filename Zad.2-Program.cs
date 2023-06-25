using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 10; // Liczba wyrazów do wygenerowania

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    public static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}