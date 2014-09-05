using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()),
            b = int.Parse(Console.ReadLine()),
            p=0;
        while (a<=b)
        {
            if (a % 5 == 0)
            {
                p++;
            }
            a++;
        }
        Console.WriteLine(p);
    }
}
