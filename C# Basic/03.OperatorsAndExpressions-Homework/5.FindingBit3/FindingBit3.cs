using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class FindingBit3
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int p = 3;
            int mask = 1<<p;
            int result = a & mask;
            int bit3 = result >> p;
            Console.WriteLine(bit3);
            Console.WriteLine(Convert.ToString(bit3,2).PadLeft(32,'0'));
        }       
    }
