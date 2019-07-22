using System;

class ArrayDemo
{
    static void Main()
    {
        int max=0;
        int[] num = new int[5];
        for(int i=0;i<5;i++)
        {
            Console.Write("Number 1 : ");
            num[i] = int.Parse(Console.ReadLine());
        }

        for(int i=0;i<5;i++)
        {
            if(max < num[i])
                max = num[i];
        }
        Console.WriteLine(max);
    }
}