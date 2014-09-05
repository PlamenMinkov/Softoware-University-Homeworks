using System;

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(
@"1-->Int
2-->Double
3-->String");
        string num = Console.ReadLine();
        switch (num)
        {
            case "1": string Int = Console.ReadLine(); Console.WriteLine(int.Parse(Int) + 1); break;
            case "2": string Doub = Console.ReadLine(); Console.WriteLine(double.Parse(Doub) + 1); break;
            case "3": string Str = Console.ReadLine(); Console.WriteLine(Str + "*"); break;
            default: Console.WriteLine("Wrong Number!");
                break;
        }

    }
}
