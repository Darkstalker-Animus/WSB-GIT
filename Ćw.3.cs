using System;

class Program
{
    static double CalculateMedian(int[] array, int length)
    {
        Array.Sort(array, 0, length); // Sortuj tylko pierwsze 'length' elementów
        if (length % 2 == 1)
        {
            return array[length / 2];
        }
        else
        {
            int middleIndex = length / 2;
            return (array[middleIndex - 1] + array[middleIndex]) / 2.0;
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 9, 1, 5, 7, 3 };
        int arrayLength = numbers.Length;

        double median = CalculateMedian(numbers, arrayLength);
        Console.WriteLine($"Mediana: {median}");
    }
}

