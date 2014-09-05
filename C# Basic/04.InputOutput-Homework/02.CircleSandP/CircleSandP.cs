using System;

class CircleSandP
{
    static void Main(string[] args)
    {
        const double pi = 3.1415926;
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("C=" + "{0:F2}", (2 * pi * r));
        Console.WriteLine("A=" + "{0:F2}", (pi * r * r));
    }
}
