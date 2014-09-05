using System;
using System.Collections.Generic;

class LongestAreaInArray
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine()), max,count=0;
        string longWord;
        string[] arr=new string[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }
        max = arr[0].Length;
        longWord=arr[0];
        count++;
        for (int i = 1; i < n; i++)
        {

            if (arr[i].Length > max)
            {
                longWord = arr[i];
                count = 1;
                max = arr[i].Length;
            }
            else if (arr[i].Length == max) count++;
        }
        Console.WriteLine(count);
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(longWord);
        }
    }
}
