using System;

public class ChangeConsoleColorDemo 
{
	static void Main(string []args)
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("Hello World");
		Console.ResetColor();
	}
}