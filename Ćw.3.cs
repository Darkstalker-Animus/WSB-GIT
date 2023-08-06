using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());

            if (height <= 0)
            {
                Console.WriteLine("Wysokość trójkąta musi być większa od zera.");
                return;
            }

            int width = height * 2 - 1;

            for (int row = 1; row <= height; row++)
            {
                int starsCount = row * 2 - 1;
                int spacesCount = (width - starsCount) / 2;

                for (int i = 0; i < spacesCount; i++)
                    Console.Write(" ");
                for (int i = 0; i < starsCount; i++)
                    Console.Write("+");
                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Wprowadzono niepoprawne dane. Wprowadź liczbę całkowitą.");
        }
    }
}

