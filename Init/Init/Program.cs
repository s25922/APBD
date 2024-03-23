using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 5, 7, 9 };
        
        double srednia = ObliczSrednia(numbers);
        Console.WriteLine($"Średnia: {srednia}");
        
        int max = FindMaxValue(numbers);
        Console.WriteLine($"Maksymalna wartość w tablicy to: {max}");
    }
    static double ObliczSrednia(int[] liczby)
    {
        if (liczby == null || liczby.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        double suma = 0;
        foreach (int liczba in liczby)
        {
            suma += liczba;
        }

        return suma / liczby.Length;
    }
    
    static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta");
        }

        int maxValue = array[0];
        for (int j = 1; j < array.Length; j++)
        {
            if (array[j] > maxValue)
            {
                maxValue = array[j];
            }
        }
        return maxValue;
    }
}


