using System;

class Program
{
    static void Main(string[] args)
    {
        int size = GetValidSizeFromUser();
        int[,] array = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = i * size + j + 1;
                }
            }
            else
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    array[i, j] = i * size + (size - j);
                }
            }
        }

        PrintArray(array);
    }

    static int GetValidSizeFromUser()
    {
        int size;
        while (true)
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            {
                return size;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

