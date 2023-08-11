using System;

class Program
{
    static void Main(string[] args)
    {
        int size = GetValidSizeFromUser();
        int[,] array = new int[size, size];

        int num = 1;
        int startRow = 0;
        int endRow = size - 1;
        int startCol = 0;
        int endCol = size - 1;

        while (num <= size * size)
        {
            for (int i = startCol; i <= endCol; i++)
            {
                array[startRow, i] = num++;
            }

            for (int i = startRow + 1; i <= endRow; i++)
            {
                array[i, endCol] = num++;
            }

            for (int i = endCol - 1; i >= startCol; i--)
            {
                array[endRow, i] = num++;
            }

            for (int i = endRow - 1; i > startRow; i--)
            {
                array[i, startCol] = num++;
            }

            startRow++;
            endRow--;
            startCol++;
            endCol--;
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

