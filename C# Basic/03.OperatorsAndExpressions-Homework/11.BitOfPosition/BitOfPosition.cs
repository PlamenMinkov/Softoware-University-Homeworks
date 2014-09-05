using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BitOfPosition
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int i;
        i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Convert.ToString(i, 2).PadLeft(32, '0'));
        Console.Write("Enter position: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int mask = 1 << b;
        int result = i & mask;
        int bit3 = result >> b;
        Console.WriteLine(bit3 == 1 ? "value=1" : "value=0");
        Console.WriteLine(Convert.ToString(bit3, 2).PadLeft(32, '0'));
    }
}
