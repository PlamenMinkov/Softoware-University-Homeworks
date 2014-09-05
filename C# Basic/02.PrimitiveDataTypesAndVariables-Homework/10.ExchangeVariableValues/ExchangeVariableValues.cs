using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 35,b=65;
        Console.WriteLine("First Valie of \"a\":{0}", a);
        Console.WriteLine("First Valie of \"b\":{0}", b);
        a = b;
        b = 22;
        Console.WriteLine("Valie of \"a\" next change:{0}", a);
        Console.WriteLine("Valie of \"b\" next change:{0}", b);
    }
}
