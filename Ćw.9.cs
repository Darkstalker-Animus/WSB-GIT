using System;

namespace SwapVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź trzy liczby a, b i c: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = c - b;
            c = a - b;
            a = a - b;

            Console.WriteLine("Nowe wartości: a = " + a + ", b = " + b + ", c = " + c);
        }
    }
}

