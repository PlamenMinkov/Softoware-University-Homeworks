using System;
using System.Collections.Generic;

class Calculations
{
    static void Main(string[] args)
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x:");
        int x = int.Parse(Console.ReadLine()),
            fact=1;
        double res = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            res += (double)fact/( Math.Pow((double)x, (double)i));
            
        }
        Console.WriteLine("res:{0:F5}",res);
    }
}
