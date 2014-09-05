using System;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main(string[] args)
    {
        string firstList = Console.ReadLine(), mask;
        string[] arr = firstList.Split(' ');

        List<string> let=new List<string>();
        for (int i = 0; i < arr.Length; i++)
                {
                    if(!let.Contains(arr[i]))
                    {
                     let.Add(arr[i]);
                    }
            
                }
        //!!!!
        let.Sort();

        
        int count=0;

        for (int i = 0; i < let.Count; i++)
        {
            count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (let[i] == arr[j])
                {
                    count++;
                }
            }
            Console.WriteLine(let[i]+"->"+count);
        }
    }
}