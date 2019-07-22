using System;

class ArrayDemo3
{
    private static double calcAverage(int []num, int size)
    {
        double n = 0;
        double avg = 0;
        for(int i=0;i<size;i++)
        {
            n = n + (double)num[i];
        }
        avg = n / size;
        return avg;
    }
    static void Main()
    {
        int []num = {45,34,74,23,74,74,23,74,88,45};
        Console.WriteLine(calcAverage(num,10));
    }
}