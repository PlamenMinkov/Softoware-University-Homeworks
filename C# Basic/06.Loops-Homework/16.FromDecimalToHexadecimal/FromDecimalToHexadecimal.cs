using System;
using System.Collections.Generic;
class FromDecimalToHexadecimal
{
    static void Main(string[] args)
    {
        int dec = int.Parse(Console.ReadLine());
        List<string> hex = new List<string>();
        int[] arr = new int[20];
        while (dec != 0)
        {
            int num = dec % 16;
            dec /= 16;
            switch (num)
            {
                case 10: hex.Add("A"); break;
                case 11: hex.Add("B"); break;
                case 12: hex.Add("C"); break;
                case 13: hex.Add("D"); break;
                case 14: hex.Add("E"); break;
                case 15: hex.Add("F"); break;
                default: hex.Add(num.ToString());break;
            }
        }
        for (int i = hex.Count-1; i >=0; i--)
        {
            Console.Write(hex[i]);
        }
        Console.WriteLine();
    }
}
