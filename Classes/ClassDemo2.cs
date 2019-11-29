using System;

class Student
{
    public string studName;
    public int rollNo;

    public void sayHello()
    {
        Console.WriteLine("Hello {0}, your roll no is {1}",studName,rollNo);
    }
}

class ClassDemo2
{
    static void Main(string []args)
    {
        Student stud = new Student();
        stud.studName = "Sam Paul";
        stud.rollNo = 34;
        stud.sayHello();
    }
}