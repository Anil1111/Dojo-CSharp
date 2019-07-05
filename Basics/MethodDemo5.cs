using System;

class MethodDemo5
{
    static void studentInfo(string name, int rollNo)
    {
        Console.WriteLine("Hello "+name+". Your roll number is "+rollNo);
    }

    static void Main()
    {
        studentInfo("Sam",34);
        studentInfo("Mike",12);
    }
}