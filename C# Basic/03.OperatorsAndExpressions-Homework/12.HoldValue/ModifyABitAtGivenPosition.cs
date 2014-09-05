using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int n, v, p;

        Console.Write("Please enter a number n=");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(7, '0'));

        Console.Write("Please eneter a possition p=");
        p = int.Parse(Console.ReadLine());

        Console.Write("Please eneter v=");
        v = int.Parse(Console.ReadLine());
        
        if (v == 0)
            n = n & (~(1 << p));

        else n = n | (v << p);

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(7, '0'));
    }
}