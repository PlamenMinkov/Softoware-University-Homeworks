using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExchangesBits
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number n=");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(26, '0'));
        uint bit3 = (number & 3) >> 3;
        uint bit4=(number & (1 << 4)) >> 4;       
        uint bit5 =(number & (1 << 5)) >> 5;
        uint bit24 = (number & (1 << 24)) >> 24;
        uint bit25 = (number & (1 << 25)) >> 25;
        uint bit26 = (number & (1 << 26)) >> 26;
       
        if (bit24 == 0)
           number = Convert.ToUInt32(number & (~(1 << 3)));
        else if(bit24==1)
            number = number | (bit24 << 3);

        if (bit25 == 0)
            number = Convert.ToUInt32(number & (~(1 << 4)));
        else if (bit25 == 1)
            number = number | (bit25 << 4);

        if (bit26 == 0)
            number = Convert.ToUInt32(number & (~(1 << 5)));
        else if (bit26 == 1)
            number = number | (bit26 << 5);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(26, '0'));
    }
}
