using System;
using System.Collections.Generic;

class RandomNumInAnyRange
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()), count = 0,
            min = int.Parse(Console.ReadLine()),
            max = int.Parse(Console.ReadLine());
        
        Random randomNumbers = new Random(n);

        for (int i = 0; i < n; i++)
            {

            int index = randomNumbers.Next(min, max);
            Console.Write(index+" ");
            }    

        Console.WriteLine();
        
    }
}
