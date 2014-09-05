using System;
using System.Collections.Generic;

class FromHexadecimalToDecimal
{
    static void Main(string[] args)
    {
        int dec = 0;
        string hex = Console.ReadLine();
        int count = 0;
        for (int i = hex.Length-1; i >=0 ; i--)
        {
            
            switch (hex[i])
            {
                case 'A': dec += (int)(15 * Math.Pow((double)16, (double)count)); break;
                case 'B': dec += (int)(11 * Math.Pow((double)16, (double)count)); break;
                case 'C': dec += (int)(12 * Math.Pow((double)16, (double)count)); break;
                case 'D': dec += (int)(13 * Math.Pow((double)16, (double)count)); break;
                case 'E': dec += (int)(14 * Math.Pow((double)16, (double)count)); break;
                case 'F': dec += (int)(15 * Math.Pow((double)16, (double)count)); break;
                case '0': dec += (int)(0 * Math.Pow((double)16, (double)count)); break;
                case '1': dec += (int)(1 * Math.Pow((double)16, (double)count)); break;
                case '2': dec += (int)(2 * Math.Pow((double)16, (double)count)); break;
                case '3': dec += (int)(3 * Math.Pow((double)16, (double)count)); break;
                case '4': dec += (int)(4 * Math.Pow((double)16, (double)count)); break;
                case '5': dec += (int)(5 * Math.Pow((double)16, (double)count)); break;
                case '6': dec += (int)(6 * Math.Pow((double)16, (double)count)); break;
                case '7': dec += (int)(7 * Math.Pow((double)16, (double)count)); break;
                case '8': dec += (int)(8 * Math.Pow((double)16, (double)count)); break;
                case '9': dec += (int)(9 * Math.Pow((double)16, (double)count)); break;
                default: dec += (int)((int)hex[i] * Math.Pow((double)16, (double)count)); break;
            }
            count++;
        }
        

        Console.WriteLine(dec);
    }
}
