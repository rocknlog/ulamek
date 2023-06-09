// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, d;

        Console.WriteLine("Podaj a");

        a = inputValue();
        Console.WriteLine("Podaj b");
        b = inputValue();
        Console.WriteLine("Podaj c");
        c = inputValue();
        Console.WriteLine("Podaj d");
        d = inputValue();
        double x, y;

        x = a * d + c * b;
        y = b * d;
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            Console.WriteLine("X to");
            Console.WriteLine(x);
            Console.WriteLine("Y to");
            Console.WriteLine(y);
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

