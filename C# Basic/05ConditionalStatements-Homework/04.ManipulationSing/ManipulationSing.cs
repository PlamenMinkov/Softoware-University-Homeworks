using System;

class ManipulationSing
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()),
            b = int.Parse(Console.ReadLine()),
            c = int.Parse(Console.ReadLine());
        if (a * b * c > 0) Console.WriteLine("+");
        else if (a * b * c < 0) Console.WriteLine("-");
        else Console.WriteLine(0);
    }
}
