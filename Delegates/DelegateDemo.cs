using System;

public class DelegateDemo
{
    public delegate double PerformCalculation(double x, double y);

    public static double Addition(double a, double b)
    {
        return a+b;
    }

    public static double Substraction(double a, double b)
    {
        return a-b;
    }

    public static double Divide(double a, double b)
    {
        return a/b;
    }

    static void Main(string []args)
    {
        PerformCalculation calc = Addition;
        calc = Addition;
        Console.WriteLine(calc(45,33));
        calc = Substraction;
        Console.WriteLine(calc(34,12));
        calc = Divide;
        Console.WriteLine(calc(45,3));
    }
}