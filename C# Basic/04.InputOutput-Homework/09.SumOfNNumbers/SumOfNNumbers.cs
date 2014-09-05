using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()),
            sum=0;
        int[] arr = new int[n];
        for (int i = 0; i <n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }
        Console.WriteLine("Sum: {0}",sum);
    }
}