using System;
using System.Collections.Generic;
using System.Linq;
class School
{
    public int regId{get;set;}
    public string schoolName{get;set;}

    public void info()
    {
        System.Console.WriteLine("School name is {0} registered with ID {1}.");
    }
}

class Student
{
    public int rollNo{get;set;}
    public string studName{get;set;}

    public int schoolId{get;set;}

    public void info()
    {
        System.Console.WriteLine("Student name is {0} and roll no is {1} from school id {2}", studName, rollNo, schoolId);
    }
}

class SchoolManager
{
    public List<School> schools;
    public List<Student> students;

    public SchoolManager()
    {
        schools = new List<School>();
        students = new List<Student>();
        schools.Add(new School{regId=11, schoolName="TechSchool"});
        schools.Add(new School{regId=25, schoolName="ArtSchool"});
        schools.Add(new School{regId=43, schoolName="SportSchool"});

        students.Add(new Student{rollNo=13,studName="Sam",schoolId=1});
        students.Add(new Student{rollNo=32,studName="Michael",schoolId=1});
        students.Add(new Student{rollNo=33,studName="Amanda",schoolId=1});
        students.Add(new Student{rollNo=54,studName="Oliver",schoolId=1});

        students.Add(new Student{rollNo=58,studName="Faisal",schoolId=2});
        students.Add(new Student{rollNo=86,studName="Mike",schoolId=2});
        students.Add(new Student{rollNo=97,studName="Theresa",schoolId=2});
        students.Add(new Student{rollNo=85,studName="Jake",schoolId=2});

        students.Add(new Student{rollNo=59,studName="Kenny",schoolId=3});
        students.Add(new Student{rollNo=50,studName="Alex",schoolId=3});
        students.Add(new Student{rollNo=61,studName="Hanna",schoolId=3});


    }

    public void fromTechSchool()
    {
        IEnumerable<Student> techStudent = from stud in students where stud.schoolId == 1 select stud;
        IEnumerable<Student> artStudent = from stud in students where stud.schoolId == 2 select stud;
        IEnumerable<Student> sportStudent = from stud in students where stud.schoolId == 3 select stud;

        Console.WriteLine("From Tech School :-");
        foreach(Student ts in techStudent)
        {
            ts.info();
        }

        System.Console.WriteLine("From Art School :-");
        foreach(Student artS in artStudent)
        {
            artS.info();
        }

        System.Console.WriteLine("From Sports School :-");
        foreach(Student sStud in sportStudent)
        {
            sStud.info();
        }

    }

    public void sortStudByRollNo()
    {
        var sortedStudents = from stud in students orderby stud.rollNo select stud;

        foreach(Student stud in sortedStudents)
        {
            stud.info();
        }
    }
}

public class LinqDemo3
{
    static void Main(string []args)
    {
        SchoolManager sm = new SchoolManager();
        sm.sortStudByRollNo();
    }
}