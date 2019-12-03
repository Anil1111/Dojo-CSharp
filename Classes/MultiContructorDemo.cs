using System;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Contructor with no parameter.");
    }    
    public MyClass(int num)
    {
        Console.WriteLine("Contructor with integer parameter.");
    }
    public MyClass(string str)
    {
        Console.WriteLine("Contructor with String parameter.");
    }
}

public class MultiContructorDemo
{
    static void Main()
    {
        new MyClass();
        new MyClass(34);
        new MyClass("sam");
    }
}