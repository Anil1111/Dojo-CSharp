using System;

class Student
{
    private string studName;
    private int rollNo;
    
    public Student(string studName, int rollNo)
    {
        this.studName = studName;
        this.rollNo = rollNo;
    }

    public String getStudentName()
    {
        return studName;
    }

    public int getRollNo() 
    {
        return rollNo;
    }
    
}

class ClassDemo2
{
    static void Main(string []args)
    {
        Student stud1 = new Student("Sam Paul",34);
        Console.WriteLine("Student Name : "+stud1.getStudentName());
        Console.WriteLine("Roll No : " + stud1.getRollNo());
    }
}