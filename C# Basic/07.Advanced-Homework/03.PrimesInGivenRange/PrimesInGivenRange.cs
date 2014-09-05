using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    public static bool Private(int n)
    {
        int i = 0;
        bool prime = true;

        for (i = 2; i < n; i++)
        {
            if (n % i == 0) prime = false;
        }

        return prime;
    }
    public static List<int> list(int min,int max)
    {
        List<int> list = new List<int>();
        for (int i = min; i <= max; i++)
        {
            if (Private(i) == true)
            {
                list.Add(i);
            }
        }
        return list;
    }
    static void Main(string[] args)
    {
        int min = int.Parse(Console.ReadLine()),
            max = int.Parse(Console.ReadLine());
        List<int> forOut = list(min, max);
        foreach (var item in forOut)
        {
            Console.Write("{0}, ",item);
        }
        Console.WriteLine();
    }
}
