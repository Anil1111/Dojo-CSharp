using System;

public class LambdaExpressionDemo
{
    public delegate string ShowMessage(string text);

    static void Main(string []args)
    {
        ShowMessage sm = (string text) => { return "Message is : "+text;};
        Console.WriteLine(sm("Hello World"));
        Console.WriteLine(sm("I'm a loser, I've got nothing to lose."));
        Console.WriteLine(sm("No wait! I've got so much to lose."));
    }
    
}