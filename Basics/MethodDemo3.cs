using System;

class MethodDemo3
{
    static string message(string message)
    {
        return "Your Message is : "+message;
    }

    static void Main()
    {
        Console.WriteLine(message("How are you"));
    }
}