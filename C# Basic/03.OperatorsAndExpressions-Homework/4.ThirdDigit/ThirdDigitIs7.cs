using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ThirdDigitIs7
{
    static void Main()
    {
        int c;
        bool b = false;
        c=Convert.ToInt32(Console.ReadLine());
        if (c < 100)
        {
            while (b == false)
            {
                c = Convert.ToInt32(Console.ReadLine());
                if (c > 100) b = true;
            }
        }
        c =c / 100;
        c = c % 10;
        Console.WriteLine(c==7?true:false);
            
    }
}

