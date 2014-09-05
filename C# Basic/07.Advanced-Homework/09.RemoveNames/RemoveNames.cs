using System;
using System.Collections.Generic;
//xyz.Replace("  ", string.empty);
class RemoveNames
{
    static void Main(string[] args)
    {
        string nameOne = Console.ReadLine();
        string nameTwo = Console.ReadLine();
        bool cond = true;
        string[] arrNames = nameOne.Split(' ');
        string[] arrNamesTwo = nameTwo.Split(' ');
        for (int i = 0; i < arrNames.Length; i++)
        {
            cond = true;
            for (int j = 0; j < arrNamesTwo.Length; j++)
            {
                if (arrNames[i] == arrNamesTwo[j])
                {
                    cond = false;
                }
            }
            if (cond == true) Console.Write(arrNames[i]+" ");
        }
        Console.WriteLine();
    }
}
