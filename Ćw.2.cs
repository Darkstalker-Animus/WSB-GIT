using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź pole koła: ");
            double P = Convert.ToDouble(Console.ReadLine());

            double promien = Math.Sqrt(P / Math.PI);
            double obwod = 2 * Math.PI * promien;

            Console.WriteLine("Obwód koła wynosi: " + obwod);
        }
    }
}

