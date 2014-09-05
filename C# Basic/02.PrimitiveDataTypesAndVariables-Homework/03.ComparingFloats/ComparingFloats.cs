using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
       double esp=0.000001,
           a=double.Parse(Console.ReadLine()),
           b = double.Parse(Console.ReadLine());
       if (a < b)
       {
           double mask = b;
           b = a;
           a = mask;
       }
       if (a - b >= esp)
       {
           Console.WriteLine("False");
       }
       else
       {
           Console.WriteLine("True");
       }
    }
}