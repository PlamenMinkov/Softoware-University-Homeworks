using System;
using System.Collections.Generic;

class ExtractURLsFromText
{
    static void Main(string[] args)
    {
        string line = @"The site nakov.com can be access from http://nakov.com or www.nakov.com. 
It has subdomains like mail.nakov.com and svetlin.nakov.com. 
Please check http://blog.nakov.com for more information.";
        string[] stringSeparators = new string[] { "http://"};
        string[] stringSeparatorsTwo = new string[] { "www." };
        List<string> adr = new List<string>();
        string[] adressAndText,adress;
        adressAndText = line.Split(stringSeparators, StringSplitOptions.None);
        for (int i = 1; i < adressAndText.Length; i++)
        {
            adress = adressAndText[i].Split(' ');
            adr.Add(stringSeparators[0]+adress[0]);
        }
        adressAndText = line.Split(stringSeparatorsTwo, StringSplitOptions.None);
        for (int i = 1; i < adressAndText.Length; i++)
        {
            adress = adressAndText[i].Split(' ');
            adr.Add(stringSeparatorsTwo[0] + adress[0]);
        }
        foreach (var item in adr)
        {
            Console.WriteLine(item);
        }
    }
}
