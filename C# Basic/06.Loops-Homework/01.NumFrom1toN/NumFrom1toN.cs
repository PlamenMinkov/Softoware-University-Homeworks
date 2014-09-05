using System;

class NumFrom1toN
{
    static void Main(string[] args)
    {
        Console.Write("N:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }
}
