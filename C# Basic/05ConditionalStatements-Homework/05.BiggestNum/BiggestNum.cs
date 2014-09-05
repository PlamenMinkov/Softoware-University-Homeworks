using System;

class BiggestNum
{
    static void Main(string[] args)
    {
        int[] a = new int[3];
        
        for (int i = 0; i < 3; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int max = a[0];
        for (int i = 0; i < 3; i++)
        {
            if (a[i] > max) max = a[i];
        }
        Console.WriteLine(max);
    }
}
