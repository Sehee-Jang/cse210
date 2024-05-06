using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating fractions using different constructors
        Fraction f1 = new Fraction(1, 1); // 1/1
        Fraction f2 = new Fraction(6, 1); // 6/1
        Fraction f3 = new Fraction(6, 7); // 6/7
        
        // Output fractions
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Example of using setters and getters
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine();

        // Set 6: Sample Output
        Fraction f4 = new Fraction(1, 1); // 1/1
        Fraction f5 = new Fraction(5, 1); // 5/1
        Fraction f6 = new Fraction(3, 4); // 3/4
        Fraction f7 = new Fraction(1, 3); // 1/3

        // Output fractions
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue());

    }
}