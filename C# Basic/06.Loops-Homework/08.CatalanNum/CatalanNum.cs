using System;
using System.Collections.Generic;

class CatalanNum
{
    static void Main(string[] args)
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        double   factN = 1L, factDoubleN = 1L, factN1 = 1L;
        double res = 1;
        
        for (double i = 1; i <= 2*n; i++)
        {
            if (i <= n +1) factN1 *= i;
            if (i <= n) factN *= i;
            factDoubleN *= i;
        }

        res = (double)factDoubleN / ((double)factN * (double)factN1);
        Console.WriteLine("res:{0}", res);
    }
}
