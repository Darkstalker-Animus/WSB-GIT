using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] validMagicSquare = new int[][]
        {
            new int[] { 8, 1, 6 },
            new int[] { 3, 5, 7 },
            new int[] { 4, 9, 2 }
        };

        int[][] nonUniqueSquare = new int[][]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 1, 1 },
            new int[] { 1, 1, 1 }
        };

        int[][] nonMagicSquare = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };

        Console.WriteLine("Select which square to check:");
        Console.WriteLine("1. Valid Magic Square");
        Console.WriteLine("2. Non-Unique Square");
        Console.WriteLine("3. Non-Magic Square");

        int choice;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }

        int[][] selectedSquare = choice switch
        {
            1 => validMagicSquare,
            2 => nonUniqueSquare,
            3 => nonMagicSquare,
            _ => null
        };

        if (selectedSquare != null)
        {
            bool isMagic = IsMagicSquare(selectedSquare);
            Console.WriteLine(isMagic ? "The selected square is a magic square." : "The selected square is not a magic square.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static bool IsMagicSquare(int[][] square)
    {
        int size = square.Length;
        int targetSum = 0;

        for (int i = 0; i < size; i++)
        {
            targetSum += square[0][i];
        }

        for (int i = 0; i < size; i++)
        {
            int rowSum = 0;
            int colSum = 0;

            for (int j = 0; j < size; j++)
            {
                rowSum += square[i][j];
                colSum += square[j][i];
            }

            if (rowSum != targetSum || colSum != targetSum)
            {
                return false;
            }
        }

        int diagonalSum1 = 0;
        int diagonalSum2 = 0;

        for (int i = 0; i < size; i++)
        {
            diagonalSum1 += square[i][i];
            diagonalSum2 += square[i][size - i - 1];
        }

        return diagonalSum1 == targetSum && diagonalSum2 == targetSum;
    }
}

