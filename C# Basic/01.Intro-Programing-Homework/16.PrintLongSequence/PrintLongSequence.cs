using System;

class PrintLongSequence
{
    static void Main(string[] args)
    {
        int mask = -5, count = 0, first=2;

        for (int i = 0; i < 1000; i++)
        {
            Console.Write(first+", ");
            first += mask;
            if (mask < 0)
            {
                mask-=2;
            }
            else
            {
                mask+=2;
            }
            mask *= -1;
            count++;
            if(count==10)
            {
                Console.WriteLine();
                count = 0;
            }
        }
    }
}
