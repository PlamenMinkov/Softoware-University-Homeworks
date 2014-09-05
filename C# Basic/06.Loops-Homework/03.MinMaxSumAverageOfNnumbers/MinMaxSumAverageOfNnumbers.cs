using System;

class MinMaxSumAverageOfNnumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()),min,max,sum=0;
        float avr;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        max = arr[0];
        min = arr[0];
        sum = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
            sum += arr[i];
        }
        avr = (float)sum /(float) n;
        Console.WriteLine(@"min: {0}
max: {1}
sum: {2}
avr: {3}",min,max,sum,avr);
    }
}
