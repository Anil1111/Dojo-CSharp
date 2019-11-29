using System;

class Student
{
    public string studName;
    public int rollNo;
    public Student(string studName, int rollNo)
    {
        this.studName = studName;
        this.rollNo = rollNo;
    }
    public void sayHello()
    {
        Console.WriteLine("Hello {0}, your roll no is {1}",studName,rollNo);
    }
}

class ClassDemo2
{
    static void Main(string []args)
    {
        Student stud1 = new Student("Sam Paul",34);
        Student stud2 = new Student("James",12);
        Student stud3 = new Student("Amanda",88);
        stud1.sayHello();
        stud2.sayHello();
        stud3.sayHello();
    }
}