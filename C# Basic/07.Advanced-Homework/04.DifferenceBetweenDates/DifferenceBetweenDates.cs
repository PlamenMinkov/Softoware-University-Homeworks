using System;
using System.Collections.Generic;

class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        string firstDate = Console.ReadLine(),
               secondDate = Console.ReadLine();
        DateTime dtOne = Convert.ToDateTime(firstDate);
        DateTime dtTwo = Convert.ToDateTime(secondDate);
        Console.WriteLine((dtTwo-dtOne).TotalDays);
        //dtTwo = dtTwo.AddDays(20);
        //Console.WriteLine(dtTwo);
    }
}
