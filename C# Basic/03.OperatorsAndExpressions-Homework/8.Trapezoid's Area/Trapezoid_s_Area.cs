using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.Trapezoid_s_Area
{
    class Trapezoid_s_Area
    {
        static void Main(string[] args)
        {
            double a, b, hight,S;
            Console.Write("WidthA: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("WidthB: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hight: ");
            hight = Convert.ToDouble(Console.ReadLine());
            S = ((a +b)/2)*hight;
            Console.WriteLine("Area= " + S);
        }
    }
}
