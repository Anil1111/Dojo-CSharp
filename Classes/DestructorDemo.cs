using System;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("This is a contructor.");
    }

    ~MyClass()
    {
        Console.WriteLine("This is a destructor.");
    }
}
public class DestructorDemo 
{
    static void Main(string []args)
    {
        MyClass myClass = new MyClass();
    }
}