using System;

class Student
{
   private string studName;
   private int rollNo;
    public string Name
    {
        get
        {
            return studName;
        }
        set
        {
            studName = value;
        }
    }

    public int roll
    {
        get
        {
            return rollNo;
        }

        set
        {
            rollNo = value;
        }
    }

    public void sayHello()
    {
        Console.WriteLine("Hello {0}, your roll no is {1}",studName,rollNo);
    }
}

class ClassPropertiesDemo
{
    static void Main(string []args)
    {
        Student stud1 = new Student();
        stud1.Name = "Sam Paul";
        stud1.roll = 34;

        stud1.sayHello();
    }
}