using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine());
        //string myHex = a.ToString("X");
        string bin = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,10:F3}", a, bin,b,c);
       
    }
}
