using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class BooleanExpressionForDivided
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine(a%5==0&&a%7==0?true:false);
        }
    }
