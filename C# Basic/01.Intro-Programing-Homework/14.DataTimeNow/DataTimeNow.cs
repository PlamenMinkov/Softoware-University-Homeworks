using System;

class DataTimeNow
{
    static void Main(string[] args)
    {
        Console.Write("Day:");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Month:");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Year:");
        int year = int.Parse(Console.ReadLine());
        DateTime startTimeFunctionTotal = DateTime.Now;
        int yearsNow = (int)startTimeFunctionTotal.Year - year;
        if (month > (int)startTimeFunctionTotal.Month ||
           (month == (int)startTimeFunctionTotal.Month &&
            day > (int)startTimeFunctionTotal.Day)) 
        {
            yearsNow--;
        }
        int nextTenYears = yearsNow + 10;

        Console.WriteLine(
@"Now I'm {0} years old 
and next ten years I will by {1} years old",yearsNow,nextTenYears);
    }
}
