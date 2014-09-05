using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PointInCircleButNotInRectangle
{
    static void Main()
    {
        double x0 = 0.0, y0 = 0.0, x, y;
        double distance;
        Console.Write("Enter point x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter point y: ");
        y = Convert.ToDouble(Console.ReadLine());
        distance = Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y));
        Console.WriteLine(distance <= 3.0 && (x < -1 || x > 1 || y < -1 || y > 5) ? "yes" : "no");
    }
}
