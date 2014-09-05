using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class OddOrEven
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a % 2;
            string odd = "odd", even = "even";
            Console.WriteLine(b);
            Console.WriteLine(b == 1 ? odd : even);
        }
    }

