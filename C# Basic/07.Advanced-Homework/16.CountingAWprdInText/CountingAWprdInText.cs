using System;
using System.Collections.Generic;

class CountingAWprdInText
{
    static void Main(string[] args)
    {
        string[] word=new string[1];
        word[0] = Console.ReadLine();
        word[0] = word[0] + " ";
        word[0] = word[0].ToLower();

        string text = @"The Software University (SoftUni) trains software engineers, 
gives them a profession and a job. Visit us at http://softuni.bg. 
Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. 
Facebook: https://www.facebook.com/SoftwareUniversity. 
YouTube: http://www.youtube.com/SoftwareUniversity. 
Google+: https://plus.google.com/+SoftuniBg/. 
Twitter: https://twitter.com/softunibg. 
GitHub: https://github.com/softuni";

        string[] symbols = new string[] { ".", ",", ";", ":", "!", "\"", "@", "?","(",")" };

        for (int i = 0; i < symbols.Length; i++)
        {
            text = text.Replace(symbols[i], " ");
        }

        string txt=text.ToLower();
        string[] all = txt.Split(word,StringSplitOptions.None);
        
        Console.WriteLine(all.Length);
    }
}
