using System;

class Program
{
    static int CalculateDij(int[,] array, int columns, int i, int j)
    {
        int dij = 0;
        for (int k = 0; k < columns; k++)
        {
            int aik = array[i, k];
            int ajk = array[j, k];
            dij += (aik - ajk) * (aik - ajk);
        }
        return dij;
    }

    static void FindClosestRows(int[,] array, int rows, int columns, out int closestRow1, out int closestRow2)
    {
        int minDij = int.MaxValue;
        closestRow1 = -1;
        closestRow2 = -1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                int dij = CalculateDij(array, columns, i, j);
                if (dij < minDij)
                {
                    minDij = dij;
                    closestRow1 = i;
                    closestRow2 = j;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 2, 3, 4 },
            { 4, 2, 3, 1 },
            { 3, 5, 1, 8 },
            { 2, 9, 4, 6 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        FindClosestRows(array, rows, columns, out int closestRow1, out int closestRow2);

        Console.WriteLine($"Najbliższe wiersze: {closestRow1} i {closestRow2}");
    }
}

