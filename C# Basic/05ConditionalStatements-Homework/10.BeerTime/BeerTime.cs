using System;

class BeerTime
{
    static void Main(string[] args)
    {
        string data = Console.ReadLine();
        string[] arr = new string[2],
            arr1 = new string[2];
        arr = data.Split(':');
        arr1 = arr[1].Split(' ');
        if (int.Parse(arr[0]) >= 0 && int.Parse(arr[0]) <= 12 &&
           int.Parse(arr1[0]) >= 0 && int.Parse(arr1[0]) <= 60)
        {
            switch (arr1[1])
            {
                case "PM": if (int.Parse(arr[0]) > 0) Console.WriteLine("beer time");
                            else Console.WriteLine("non-beer time");break;
                case "AM": if (int.Parse(arr[0]) < 3) Console.WriteLine("beer time"); 
                            else Console.WriteLine("non-beer time");break;
                default: Console.WriteLine("non-beer time");
                    break;
            }
        }
        else Console.WriteLine("invalid time!");
    }
}
