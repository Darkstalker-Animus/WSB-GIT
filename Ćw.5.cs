using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź pierwszą liczbę: ");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź drugą liczbę: ");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            if (liczba1 > liczba2)
            {
                Console.WriteLine("Większa liczba: " + liczba1);
            }
            else
            {
                Console.WriteLine("Większa liczba: " + liczba2);
            }
        }
    }
}
