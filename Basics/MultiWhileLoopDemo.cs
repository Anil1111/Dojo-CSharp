using System;

class MultiWhileLoopDemo
{
	static void Main()
	{
		int num1 = 1;
		int num2;
		while(num1 < 10)
		{
			num2 = 1;
			while(num2 < num1)
			{
				Console.Write(num2);
				num2++;
			}
			num1++;
			Console.WriteLine();
		}
	}
}