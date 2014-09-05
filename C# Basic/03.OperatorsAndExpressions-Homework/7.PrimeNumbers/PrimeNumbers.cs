using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrimeNumbers
{
    static void Main()
    {
        int i=0, n;
        bool prime = false;
        n = Convert.ToInt32(Console.ReadLine());
        while (prime == false&&i<n)
        {
            for (i = 2; i < n; i++)
            {
                if (n % i == 0) prime = true;
            }
        }
        Console.WriteLine(prime==false?"This number is prim":"This number is not prime");
    }
}

