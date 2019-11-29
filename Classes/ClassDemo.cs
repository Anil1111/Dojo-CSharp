using System;

class Student
{
    public void sayHello()
    {
        Console.WriteLine("Hello");
    }
}

class ClassDemo
{
    static void Main(string []args)
    {
        Student stud = new Student();
        stud.sayHello();
    }
}