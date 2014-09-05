using System;

class GreaterIntiger
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()),
            b = int.Parse(Console.ReadLine());
        if(a>b)
        {
            Console.WriteLine(a);
        }
        else Console.WriteLine(b);
    }
}
