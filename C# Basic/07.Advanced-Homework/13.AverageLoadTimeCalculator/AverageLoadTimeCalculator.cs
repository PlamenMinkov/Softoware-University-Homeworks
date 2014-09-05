using System;
using System.Collections.Generic;

class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        string line = @"2014-Apr-01 02:01 http://softuni.bg 8,37725
2014-Apr-01 02:05 http://www.nakov.com 11,622
2014-Apr-01 02:06 http://softuni.bg 4,33
2014-Apr-01 02:11 http://www.google.com 1,94
2014-Apr-01 02:11 http://www.google.com 2,011
2014-Apr-01 02:12 http://www.google.com 4,882
2014-Apr-01 02:34 http://softuni.bg 4,885
2014-Apr-01 02:36 http://www.nakov.com 10,74
2014-Apr-01 02:36 http://www.nakov.com 11,75
2014-Apr-01 02:38 http://softuni.bg 3,886
2014-Apr-01 02:44 http://www.google.com 1,04
2014-Apr-01 02:48 http://www.google.com 1,4555
2014-Apr-01 02:55 http://www.google.com 1,977";
        string[] arrStr = line.Split('\n');
        string[] adressAndTime,text,adress = new string[arrStr.Length];
        double[] time = new double[arrStr.Length];
        
        string[] stringSeparators = new string[] { "http://" };
        List<string> adr = new List<string>();
        double sum = 0, count = 0,times;
            
            for (int i = 0; i < arrStr.Length; i++)
            {
                text = arrStr[i].Split(stringSeparators, StringSplitOptions.None);
                adressAndTime = text[1].Split(' ');
                adress[i] = adressAndTime[0];
                time[i] = Convert.ToDouble(adressAndTime[1]);
                
            }

            for (int i = 0; i < adress.Length; i++)
            {
                if (!adr.Contains(adress[i]))
                {
                    adr.Add(adress[i]);
                }

            }
            //!!!!
            adr.Sort();
            for (int i = 0; i < adr.Count; i++)
            {
                count = 0;
                sum = 0;
                for (int j = 0; j < adress.Length; j++)
                {
                    if (adr[i] == adress[j])
                    {
                        count++;

                        sum += time[j];
                    }
                }
                Console.WriteLine(adr[i] + "-->" + sum / count);
            }
    }
}