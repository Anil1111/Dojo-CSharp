using System;

class StudentInfo
{
    public int RollNo { get; set; }
    public string StudentName { get; set; }
}

public class PropertiesDemo
{
    static void Main(string []args)
    {
        StudentInfo stud1 = new StudentInfo();
        stud1.RollNo = 34;
        stud1.StudentName = "Sam Paul";

        Console.WriteLine("Student name is {0} and his roll no is {1}",stud1.StudentName,stud1.RollNo);
    }
}