using System;
using System.Collections.Generic;

class JoinList
{
    static void Main(string[] args)
    {
        string firstList = Console.ReadLine();
        string secondList = Console.ReadLine(),mask;
        string[] arrFirst = firstList.Split(' ');
        string[] arrSecond = secondList.Split(' ');

        List<string> list = new List<string>();
        int maxLen = 0;

        if (arrFirst.Length > arrSecond.Length) maxLen = arrFirst.Length;
        else maxLen = arrSecond.Length;

        for (int i = 0; i < maxLen; i++)
        {
            if (i < arrFirst.Length) list.Add(arrFirst[i]);
            if (i < arrSecond.Length) list.Add(arrSecond[i]);
            
        }

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i+1; j < list.Count; j++)
            {

                if (list[i] == list[j])
                {
                    list.RemoveAt(j);
                }
            }
            
        }

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (int.Parse(list[i]) < int.Parse(list[j]))
                {
                    mask = list[i];
                    list[i] = list[j];
                    list[j] = mask;
                }
            }
        }
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
