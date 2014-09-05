using System;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        string symbol = "\u00A9";
        Console.WriteLine(@"
                             {0}           
                            {0} {0}
                           {0}   {0}
                          {0} {0} {0} {0}
                          ", symbol);
    }
}
