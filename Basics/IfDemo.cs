using System;

class IfDemo
{
	static void Main()
	{
		int num;
		Console.Write("Enter a number : ");
		num = int.Parse(Console.ReadLine());
		
		if(num % 2 == 0)
		{
			Console.WriteLine("Number is even.");
		}
		else
		{
			Console.WriteLine("Number is Odd.");
		}
	}
}