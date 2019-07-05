using System;

class MultiIfElseDemo
{
	static void Main()
	{
		int num1, num2, num3;
		Console.Write("Enter number 1 	: ");
		num1 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter number 2 	: ");
		num2 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter number 3 	: ");
		num3 = int.Parse(Console.ReadLine());
		
		if(num1 > num2)
		{
			if(num1 > num3)
			{
				Console.WriteLine(num1 + " is the largest number.");
			}
			else
			{
				Console.WriteLine(num3 + " is the largest number.");
			}
		}
		else
		{
			if(num2 > num3)
			{
				Console.WriteLine(num2 + " is the largest number.");
			}
			else
			{
				Console.WriteLine(num3 + " is the largest number.");
			}
		}
	}
}