using System;

class Program
{
    static void Main(string[] args)
    {
        int size = 10;
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

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

