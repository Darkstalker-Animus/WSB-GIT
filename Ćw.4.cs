using System;

namespace RombProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAttempts = 3;
            int attempts = 0;
            int numRows;

            while (true)
            {
                Console.Write("Podaj nieparzystą liczbę wierszy większą lub równą 3: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numRows) && numRows >= 3 && numRows % 2 != 0)
                    break;

                attempts++;
                if (attempts >= maxAttempts)
                {
                    Console.WriteLine("Nieprawidłowa wartość podana 3 razy. Koniec programu.");
                    return;
                }

                Console.WriteLine("Nieprawidłowa wartość. Spróbuj ponownie.");
            }

            char[] borderChars = { '#', '@', '|', '*' };
            char[] interiorChars = { '.', ':', '-', '+' };
            Random random = new Random();

            // górna połowa rombu
            for (int i = 1; i <= numRows / 2 + 1; i++)
            {
                int numSpaces = numRows / 2 + 1 - i;
                int numInteriorChars = 2 * i - 1;
                char borderChar = borderChars[random.Next(0, borderChars.Length)];
                char interiorChar = interiorChars[random.Next(0, interiorChars.Length)];

                DrawRow(numSpaces, numInteriorChars, borderChar, interiorChar);
            }

            // dolna połowa rombu
            for (int i = numRows / 2; i >= 1; i--)
            {
                int numSpaces = numRows / 2 + 1 - i;
                int numInteriorChars = 2 * i - 1;
                char borderChar = borderChars[random.Next(0, borderChars.Length)];
                char interiorChar = interiorChars[random.Next(0, interiorChars.Length)];

                DrawRow(numSpaces, numInteriorChars, borderChar, interiorChar);
            }
        }

        static void DrawRow(int numSpaces, int numInteriorChars, char borderChar, char interiorChar)
        {
            for (int j = 0; j < numSpaces; j++)
            {
                Console.Write(" ");
            }

            Console.Write(borderChar);

            for (int j = 0; j < numInteriorChars; j++)
            {
                Console.Write(interiorChar);
            }

            Console.Write(borderChar);
            Console.WriteLine();
        }
    }
}
