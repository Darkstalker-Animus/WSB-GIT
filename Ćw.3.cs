using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź wagę w kg: ");
            double waga = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź wzrost w metrach: ");
            double wzrost = Convert.ToDouble(Console.ReadLine());

            double bmi = waga / (wzrost * wzrost);

            Console.WriteLine("Twój BMI wynosi: " + bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Waga prawidłowa");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Nadwaga");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine("Otyłość");
            }
        }
    }
}

