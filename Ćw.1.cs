using System;

class Program
{
    static string FormatTime(int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }

    static void Main(string[] args)
    {
        int elapsedTimeInSeconds = 332;
        string formattedTime = FormatTime(elapsedTimeInSeconds);
        Console.WriteLine(formattedTime);
    }
}

