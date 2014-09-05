using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberToAText
{
    public static void Digits(int number)
    {
        switch (number)
        {
            case 0: Console.WriteLine(" Zero "); break;
            case 1: Console.Write(" One "); break;
            case 2: Console.Write(" Two "); break;
            case 3: Console.Write(" Three "); break;
            case 4: Console.Write(" Four "); break;
            case 5: Console.Write(" Five "); break;
            case 6: Console.Write(" Six "); break;
            case 7: Console.Write(" Seven "); break;
            case 8: Console.Write(" Eight "); break;
            case 9: Console.Write(" Nine "); break;
            default: break;
        }
    }

    public static void SpecialCases(int number)
    {
        switch (number)
        {
            case 10: Console.Write(" Ten "); break;
            case 11: Console.Write(" Eleven "); break;
            case 12: Console.Write(" Twelve "); break;
            case 13: Console.Write(" Thirteen "); break;
            case 14: Console.Write(" Fourteen "); break;
            case 15: Console.Write(" Fifteen "); break;
            case 16: Console.Write(" Sixteen "); break;
            case 17: Console.Write(" Seventeen "); break;
            case 18: Console.Write(" Eighteen "); break;
            case 19: Console.Write(" Nineteen "); break;
            default: break;
        }
    }

    public static void Tens(int number)
    {
        switch (number)
        {
            case 2: Console.Write(" Twenty "); break;
            case 3: Console.Write(" Thirty "); break;
            case 4: Console.Write(" Fourty "); break;
            case 5: Console.Write(" Fifty "); break;
            case 6: Console.Write(" Sixty "); break;
            case 7: Console.Write(" Seventy "); break;
            case 8: Console.Write(" Eighty "); break;
            case 9: Console.Write(" Ninety "); break;
            default: break;
        }
    }

    public static void Hundreds(int number)
    {
        switch (number)
        {
            case 1: Console.Write(" One Hundred "); break;
            case 2: Console.Write(" Two Hunderd "); break;
            case 3: Console.Write(" Three Hundred "); break;
            case 4: Console.Write(" Four Hundred "); break;
            case 5: Console.Write(" Five Hundred "); break;
            case 6: Console.Write(" Six Hundred "); break;
            case 7: Console.Write(" Seven Hundred "); break;
            case 8: Console.Write(" Eight Hundred "); break;
            case 9: Console.Write(" Nine Hundred "); break;
            default: break;
        }
    }
    static void Main(string[] args)
    {
        int number, units, tens, hundreds, Specials;
        Console.WriteLine("Enter number between 0 and 999");
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        units = number % 10;
        tens = (number / 10) % 10;
        hundreds = (number / 100) % 10;
        Specials = number % 100;

        while (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid input. Only numbers in the range [0-999]\n");
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }

        //Digits
        if (number < 10)
        {
            Digits(units);
        }
        //Special cases (10 to 19)
        else if (number >= 10 && number <= 19)
        {
            SpecialCases(number);
        }
        //Tens
        else if (number >= 20 && number < 100) //numbers between 20 and 99
        {

            if (units == 0)
            {
                Tens(tens);
            }
            else
            {
                Tens(tens);
                Digits(units);
            }
        }
        //Hundreds
        else if (number >= 100 && number < 1000)
        {
            Hundreds(hundreds);
            if (units == 0 && tens == 0) Hundreds(hundreds);

            else if (units != 0 && tens == 0)
            {
                Console.Write("and");
                Digits(units);
            }

            else if (Specials >= 10 && Specials < 20)
            {
                Console.Write("and");
                SpecialCases(Specials);
            }

            else if (units == 0 && tens != 0)
            {
                Console.Write("and");
                Tens(tens);
            }
            else if (units != 0 && tens != 0)
            {
                Console.Write("and");
                Tens(tens);
                Digits(units);
            }
        }
        Console.WriteLine();
    }
}

