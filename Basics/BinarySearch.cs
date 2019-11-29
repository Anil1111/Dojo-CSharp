using System;

class BinarySearchDemo
{
    static void Main(string []args)
    {
        int[] num = {10,34,64,74,83,84,89,99}; // This data must be sorted in ascending order for binary search to work.
        int searchNum = 74;
        Console.WriteLine(Array.BinarySearch(num,searchNum));
    }
}