using System;

public class OutDemo
{
    private static void number(out int a, out int b)
    {
        a = 45;
        b = 62;
    }

    public static void Main()
    {
        int a,b;
        number(out a,out b);
        Console.WriteLine("Number 1 is : "+a);
        Console.WriteLine("Number 2 is : "+b);
    }
}