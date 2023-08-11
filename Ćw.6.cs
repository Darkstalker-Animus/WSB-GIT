using System;

class Program
{
    static double RecursiveAverage(double[] array, int size, int index = 0, double sum = 0)
    {
        if (index >= size)
        {
            if (size > 0)
                return sum / size;
            else
                throw new ArgumentException("Rozmiar tablicy musi być większy niż 0.");
        }

        sum += array[index];
        return RecursiveAverage(array, size, index + 1, sum);
    }

    static void Main(string[] args)
    {
        double[] numbers = { 3.5, 2.0, 5.5, 1.0, 4.0 };
        int arraySize = numbers.Length;

        double average = RecursiveAverage(numbers, arraySize);
        Console.WriteLine($"Średnia arytmetyczna: {average}");
    }
}

