using System;
using System.Collections.Generic;

class RandomizeNum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()),count=0;
        List<int> num = new List<int>(n);
        for (int i = 1; i <= n; i++)
        {
            num.Add(i);
        }
        Random randomNumbers = new Random(n);

        while (count<n)
        {
            
            int index = randomNumbers.Next(1, n);
            
            for(int i=0;i<num.Count;i++)
            {

                if (num[i] == index)
                {
                    Console.Write(num[i]+" ");
                    num[i] = 0;
                    count++;
                }
                
            }
        }

        Console.WriteLine();
        
    }
}
