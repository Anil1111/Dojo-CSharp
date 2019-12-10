using System;

class LambdaExpressionDemo4
{
    public delegate string DisplayStudentInfo(string studName, int rollNo);
    static void Main(string []args)
    {
        DisplayStudentInfo studInfo = (studName,rollNo) => "Hello "+studName+", your roll no is "+rollNo;
        Console.WriteLine(studInfo("Sam",34));
        
    }
}