using System;

class Fibonacci
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        arr[0]=0;
        if (n == 1)
        {
            Console.WriteLine(arr[0]);
        }
        else if (n == 2)
        {
            arr[1] = 1;
            Console.WriteLine(arr[0] + ", " + arr[1]);
        }
        else
        {
            arr[1] = 1;
            Console.Write(arr[0] + ", " + arr[1] + ", ");
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
                Console.Write( arr[i]);
                if (i + 1 < n)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
