using System;

class Sort
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
            for (int j = 0; j < i; j++)
            {
                    if (a[i] < a[j])
                {
                    max = a[j];
                    a[j] = a[i];
                    a[i] = max;                
                }
            }
            
        }
        for (int i = 0; i < 3; i++)
        {
            Console.Write(a[i]+" ");
        }
    }
}