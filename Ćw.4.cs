using System;

namespace FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź cztery liczby całkowite (a, b, c, d): ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            if (b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązania");
            }
            else
            {
                int x = a * d + b * c;
                int y = b * d;

                Console.WriteLine("Ułamek: " + x + "/" + y);
            }
        }
    }
}

