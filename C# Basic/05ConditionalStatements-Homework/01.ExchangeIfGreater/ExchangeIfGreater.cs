using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()),
            b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            int mask = b;
            b = a;
            a = mask;
        }
        Console.WriteLine(a+" "+b);
    }
}
