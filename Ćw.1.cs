using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 10;
        int cols = 10;
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = i * cols + j + 1;
                }
            }
            else
            {
                for (int j = cols - 1; j >= 0; j--)
                {
                    array[i, j] = i * cols + (cols - j);
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

