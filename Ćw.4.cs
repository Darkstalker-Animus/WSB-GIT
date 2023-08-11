using System;

class Program
{
    static void Main(string[] args)
    {
        int maxSize = Console.WindowHeight - 2;
        int size = GetValidSizeFromUser(maxSize);

        int[,] array = new int[maxSize, maxSize];

        for (int i = 0; i < maxSize; i++)
        {
            for (int j = 0; j < maxSize; j++)
            {
                array[i, j] = 0;
            }
        }

        FillArray(array, size);

        PrintArray(array, size);
    }

    static int GetValidSizeFromUser(int maxSize)
    {
        int size;
        while (true)
        {
            Console.Write($"Enter the size of the array (up to {maxSize}): ");
            if (int.TryParse(Console.ReadLine(), out size) && size > 0 && size <= maxSize && size % 2 != 0)
            {
                return size;
            }
            Console.WriteLine($"Invalid input. Please enter an odd positive integer up to {maxSize}.");
        }
    }

    static void FillArray(int[,] array, int size)
    {
        int num = 1;

        for (int i = size - 1; i >= 0; i--)
        {
            int row = i;
            int col = 0;

            while (row < size && col < size)
            {
                if (i % 2 == 0)
                {
                    array[row, col] = num++;
                }
                else
                {
                    array[col, row] = num++;
                }
                row++;
                col++;
            }
        }
    }

    static void PrintArray(int[,] array, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{array[i, j],2}\t");
            }
            Console.WriteLine();
        }
    }
}

