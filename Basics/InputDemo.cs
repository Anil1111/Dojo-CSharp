using System;

class InputDemo
{
	static void Main()
	{
		string studName;
		int rollNo;
		
		Console.Write("Enter your name : ");
		studName = Console.ReadLine();
		Console.Write("Enter your Roll : ");
		rollNo = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Hello {0}. Your roll no is {1}.",studName,rollNo);
	}
}