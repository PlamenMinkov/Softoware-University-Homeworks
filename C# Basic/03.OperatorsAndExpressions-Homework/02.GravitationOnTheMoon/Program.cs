using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете тежестта на Земята:");
            double onEarth = double.Parse(Console.ReadLine());
            Console.WriteLine("Тежест на луната:{0}",0.17*onEarth);
        }
    }
}
