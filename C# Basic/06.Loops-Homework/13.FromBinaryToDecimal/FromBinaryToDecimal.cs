using System;
using System.Collections.Generic;

class FromBinaryToDecimal
{
    static void Main(string[] args)
    {
        int dec = 0;
        string bin = Console.ReadLine();
        int count = 0;
        for (int i = bin.Length - 1; i >= 0; i--)
        {

                switch (bin[i])
                {
                    case '1': dec += (int)((int)1 * Math.Pow((double)2, (double)count)); break;
                    case '0': dec += (int)((int)0 * Math.Pow((double)2, (double)count)); break;
                    default: Console.WriteLine("Fatal Error!");
                        break;
                }
            count++;
        }


        Console.WriteLine(dec);
    }
}
