using System;

public class LambdaExpressionDemo3
{
    public delegate string PrintMessage(string message);
    static void Main(string []args)
    {
        PrintMessage pm = message => "This is the message I received : " + message;
        Console.WriteLine(pm("Hello World, I've been waiting for the chance to see your face."));
    }
}