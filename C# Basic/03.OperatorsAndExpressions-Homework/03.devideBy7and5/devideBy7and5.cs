using System;

class devideBy7and5
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        bool pr = false;
        if (a % 5 == 0 && a % 7 == 0)
        {
            pr = true;
        }
        Console.WriteLine(pr);
    }
}
