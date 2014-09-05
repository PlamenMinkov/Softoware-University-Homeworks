using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PositionBit
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter position: ");
        int p=Convert.ToInt32(Console.ReadLine());
        int mask = 1 << p;
        int result = a & mask;
        int bit = result >> p;
        Console.WriteLine(bit);
        
    }
}

