using System;
using System.Collections.Generic;

class CalculateN_DevidedByK_
{
    static void Main(string[] args)
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k:");
        int k = int.Parse(Console.ReadLine()),
            factN = 1, factK = 1 ;
        double res = 1,max=0;
        if(n>k)max=n;
        else max=k;
        for (int i = 1; i <= max; i++)
        {
            if (i <= n) factN *= i;
            if (i <= k) factK *= i;
        }
        res = (double)factN / (double)factK;
        Console.WriteLine("res:{0}", res);
    }
}
