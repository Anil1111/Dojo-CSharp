using System;

struct Student
{
    public string studName;
    public int rollNo;

    public void GetInfo()
    {
        Console.WriteLine("Student's name is {0} and the roll no is {0}",studName, rollNo);
    }
}
public class StructureDemo2
{
    static void Main(string []args)
    {
        Student stud;
        stud.rollNo = 34;
        stud.studName = "Sam Paul";
        stud.GetInfo();
    }
}