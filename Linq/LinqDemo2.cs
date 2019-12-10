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
        schools.Add(new School{regId=1, schoolName="TechSchool"});
        schools.Add(new School{regId=2, schoolName="ArtSchool"});
        schools.Add(new School{regId=3, schoolName="SportSchool"});

        students.Add(new Student{rollNo=1,studName="Sam",schoolId=1});
        students.Add(new Student{rollNo=2,studName="Michael",schoolId=1});
        students.Add(new Student{rollNo=3,studName="Amanda",schoolId=1});
        students.Add(new Student{rollNo=4,studName="Oliver",schoolId=1});

        students.Add(new Student{rollNo=5,studName="Faisal",schoolId=2});
        students.Add(new Student{rollNo=6,studName="Mike",schoolId=2});
        students.Add(new Student{rollNo=7,studName="Theresa",schoolId=2});
        students.Add(new Student{rollNo=8,studName="Jake",schoolId=2});

        students.Add(new Student{rollNo=9,studName="Kenny",schoolId=3});
        students.Add(new Student{rollNo=10,studName="Alex",schoolId=3});
        students.Add(new Student{rollNo=11,studName="Hanna",schoolId=3});


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
}

public class LinqDemo2
{
    static void Main(string []args)
    {
        SchoolManager sm = new SchoolManager();
        sm.fromTechSchool();
    }
}