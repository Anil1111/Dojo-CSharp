using System;

class VarDemo
{
    static void Main()
    {
        var name = "Sam Paul";
        var rollNo = 34;

        Console.WriteLine("Name variable is a type of : "+name.GetType().ToString());
        Console.WriteLine("RollNo variable is a type of : "+rollNo.GetType().ToString());
    }
}