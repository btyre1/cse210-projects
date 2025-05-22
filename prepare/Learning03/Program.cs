using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine($"{f1.GetFractionString()}\n{f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()}\n{f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()}\n{f3.GetDecimalValue()}");
        Console.WriteLine($"{f4.GetFractionString()}\n{f4.GetDecimalValue()}");
    }
}