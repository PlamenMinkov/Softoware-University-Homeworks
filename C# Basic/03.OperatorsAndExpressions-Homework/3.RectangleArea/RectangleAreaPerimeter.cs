using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RectangleAreaPerimeter
{
    static void Main()
    {
        double a, b,S,P;
        Console.Write("Width: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Hight: ");
        b = Convert.ToDouble(Console.ReadLine());
        S = a * b;
        P = 2 * a + 2 * b;
        Console.WriteLine("Perimeter= " + P);
        Console.WriteLine("Area= "+S);
    }
}

