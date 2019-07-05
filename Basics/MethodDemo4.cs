using System;

class MethodDemo4
{
    static int add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int substract(int num1, int num2)
    {
        return num1 - num2;
    }

    static void Main()
    {
        Console.WriteLine(add(34,45));
        Console.WriteLine(substract(45,23));
    }
}