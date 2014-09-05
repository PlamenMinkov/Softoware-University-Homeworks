using System;

class DeckOfCards
{
    static void Main(string[] args)
    {
        string[] cards=new 
            string[14]{"1","2","3","4","5","6","7","8","9","10","J","Q","K","A"};

        for (int i = 0; i < cards.Length; i++)
        {
            Console.WriteLine("{0}{1}  {2}{1}  {3}{1}  {4}{1}",
                               (char)3,cards[i],(char)4,(char)5,(char)6);
            Console.WriteLine();
        }
    }
}
