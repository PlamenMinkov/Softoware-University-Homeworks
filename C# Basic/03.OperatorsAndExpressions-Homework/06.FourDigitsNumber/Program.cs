using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()),sum=0;
        int[] mask=new int[4];
        for (int i = 0; i < 4; i++)
        {
            mask[i] = a % 10;
            a = a / 10;
            sum += mask[i];
        }
        Console.WriteLine("Сумата на цифрите:{0}",sum);
        Console.Write("Цифрите в обратен ред:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(mask[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Последната цифра на първа позиция:{0}{1}{2}{3}",
                       mask[0],mask[3],mask[2],mask[1]);
        Console.WriteLine("Числото с размяна на позициите на 2ра и 3та цифра:{0}{1}{2}{3}",
                       mask[3], mask[1], mask[2], mask[0]);
    }
}
