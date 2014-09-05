using System;

class SumOf5Num
{
    static void Main(string[] args)
    {
        string[] tokens = Console.ReadLine().Split();
        int a = int.Parse(tokens[0]);
        int b = int.Parse(tokens[1]),
            c = int.Parse(tokens[2]),
            d = int.Parse(tokens[3]),
            e = int.Parse(tokens[4]);
        Console.WriteLine("Sum: {0}",a+b+c+d+e);
    }
}

