using System;
using System.Collections.Generic;

class Fibonacci
{
   public static int Fib(int n)
    {
        int[] arr = new int[n+1];

            for (int i = 0; i <= n; i++)
            {
                if (i == 1 || i == 0)
                {
                    arr[i]=1;
                }
                else
                {
                arr[i] = arr[i - 2] + arr[i - 1];
                }

            }
            return arr[n];        
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
       
        Console.WriteLine(Fib(n));
    }
    
}