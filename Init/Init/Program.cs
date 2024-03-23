using System;

class Program
{
    static void Main(string[] args)
    {
        int[] przykladoweLiczby = { 1, 3, 5, 7, 9 };
        double srednia = ObliczSrednia(przykladoweLiczby);
        Console.WriteLine($"Średnia: {srednia}");
    }
    public static double ObliczSrednia(int[] liczby)
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
}


