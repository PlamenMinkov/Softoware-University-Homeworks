using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExchangePbitsWithQbits
{
    static void Main(string[] args)
    {
        uint[] bitp = new uint[100], bitq = new uint[100];
        Console.Write("Please enter a number n=");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(26, '0'));

        Console.Write("Please enter p=");
        uint p = uint.Parse(Console.ReadLine());
        Console.Write("Please enter q=");
        uint q = uint.Parse(Console.ReadLine());
        Console.Write("Please enter k=");
        uint k = uint.Parse(Console.ReadLine());
       
        for (uint i = 0; i < k; i++)
        {

            bitq[i] = (number & (1U << (int)q)) >> (int)q;
            q++;
            Console.WriteLine(bitq[i]);
            Console.WriteLine(Convert.ToString(bitq[i], 2).PadLeft(26, '0'));
        }

        for (uint i = 0; i < k; i++)
        {
            uint mask;
            mask = bitq[i] << (int)p;
            if (bitq[i] == 0)
                number = Convert.ToUInt32(number & (~(1 << (int)p)));
            else number = number | mask;
            p++;
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(26, '0'));
    }
}
