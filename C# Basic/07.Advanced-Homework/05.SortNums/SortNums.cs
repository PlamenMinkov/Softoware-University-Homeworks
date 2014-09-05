using System;
using System.Collections.Generic;
class SortNums
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()),mask;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i] < arr[j])
                {
                    mask = arr[i];
                    arr[i] = arr[j];
                    arr[j] = mask;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");       
        }
        Console.WriteLine();
    }
}
