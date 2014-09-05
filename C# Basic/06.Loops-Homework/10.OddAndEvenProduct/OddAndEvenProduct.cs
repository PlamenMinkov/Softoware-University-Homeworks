using System;
using System.Collections.Generic;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
            string[] arr= num.Split(' ');
            int odd_product = 1, even_product = 1;

            foreach (var item in arr)
            {
                int i=Convert.ToInt32(item);
                if(i%2==0)
                {
                    even_product *=i;
                }
                else odd_product *= i;
            }

            if (odd_product == even_product)
            {
                Console.WriteLine(@"yes
product:{0}", even_product);
            }
            else Console.WriteLine(@"no
even_product:{0}
odd_product:{1}", even_product, odd_product);
    }
}
