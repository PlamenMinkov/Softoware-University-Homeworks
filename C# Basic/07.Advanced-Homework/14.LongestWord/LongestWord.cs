using System;
using System.Collections.Generic;

class LongestWord
{
    static void Main(string[] args)
    {
        string text = @"The C# Basics course is awesome start in programming 
with C# and Visual Studio.";
        string[] symbols = new string[] {".",",",";",":","!","\"","@","?" };
        List<string> words = new List<string>();
        int max; string word;

        for (int i = 0; i < symbols.Length; i++)
        {
            text = text.Replace(symbols[i], "");
        }
        string[] arr = text.Split(' ');
        for (int i = 0; i < arr.Length; i++)
        {
            if (!words.Contains(arr[i]))
            {
                words.Add(arr[i]);
            }

        }
        max = words[0].Length; word = words[0];
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].Length > max)
            {
                max = words[i].Length;
                word = words[i];
            }
        }
        Console.WriteLine(word);
    }
}
