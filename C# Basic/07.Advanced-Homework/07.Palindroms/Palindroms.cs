using System;
using System.Collections.Generic;

class Palindroms
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine()),
            c = int.Parse(Console.ReadLine());
        List<char> letters = new List<char>() {'a','b','c','d','e','f','g','h','i','j','k',
                                               'l','m','n','o','p','q','r','s','t','u',
                                                'v','w','x','y','z'};
        for (int i = 0; i < r; i++)
        {
            for (int j = i; j < c+i; j++)
            {
                string outLetters=letters[i]+""+letters[j]+""+letters[i];
                Console.Write("{0} ",outLetters);
            }
            Console.WriteLine();
        }
    }
}
