using System;
using System.Collections.Generic;

class FromDecimalToBinary
{
    static void Main(string[] args)
    {
        int dec = int.Parse(Console.ReadLine());
        List<int> bin = new List<int>();
        int[] arr = new int[20];
        while (dec != 0)
        {
            int num = dec % 2;
            dec /= 2;
            
                bin.Add(num);
            
        }
        for (int i = bin.Count - 1; i >= 0; i--)
        {
            Console.Write(bin[i]);
        }
        Console.WriteLine();
    }
}
