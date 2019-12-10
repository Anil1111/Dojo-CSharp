using System;

public class MulticastDelegateDemo
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
        PerformCalculation calc1 = Addition;
        PerformCalculation calc2 = Substraction;
        PerformCalculation mix = calc1 + calc2;
        Console.WriteLine(mix); 
    }
}