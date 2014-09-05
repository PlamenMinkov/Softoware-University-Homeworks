using System;
using System.Collections.Generic;

class PrimeChecker
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
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(Private(num));
    }
}
