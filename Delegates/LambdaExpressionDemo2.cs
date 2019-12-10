using System;

public class LambdaExpressionDemo2
{
    public delegate void PrintMessage(string message);
    static void Main(string []args)
    {
        PrintMessage pm = (string message)=> {
            Console.WriteLine("The message I received is : " + message);
            Console.WriteLine("This is the end.");
        };
        pm("This is the beginning.");
    }
}