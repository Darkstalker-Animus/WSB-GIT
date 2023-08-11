using System;

namespace EquilateralTriangleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź długość pierwszego boku trójkąta: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź długość drugiego boku trójkąta: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź długość trzeciego boku trójkąta: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Można utworzyć trójkąt równoboczny");
            }
            else
            {
                Console.WriteLine("Nie można utworzyć trójkąta równobocznego");
            }
        }
    }
}

