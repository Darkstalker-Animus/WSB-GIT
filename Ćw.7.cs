using System;

namespace PointInsideCircleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź współrzędną x punktu P: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź współrzędną y punktu P: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź współrzędną a środka koła: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź współrzędną b środka koła: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź promień r koła: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double odleglosc = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));

            if (odleglosc <= r)
            {
                Console.WriteLine("Punkt P leży w obrębie koła.");
            }
            else
            {
                Console.WriteLine("Punkt P nie leży w obrębie koła.");
            }
        }
    }
}
