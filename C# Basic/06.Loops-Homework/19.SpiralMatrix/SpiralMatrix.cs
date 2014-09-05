using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        int maxX,maxY,minX=0,minY=0,count=1;
	int num;
	
	int[,] arr=new int[100,100];
	Console.Write("N: ");
    num = int.Parse(Console.ReadLine());
	maxY=num-1;
	maxX=num-1;
        while(count<=num*num)
        {
	        for (int i = minY; i <= maxY; i++)
	        {
		        arr[minX,i]=count++;
	        }
	        minX++;
	        for (int i = minX; i <= maxX; i++)
	        {
		        arr[i,maxY]=count++;
	        }
	        maxY--;
	        for (int i = maxY; i >= minY; i--)
	        {
		        arr[maxX,i]=count++;
	        }
	        maxX--;
	        for (int i = maxX; i >=minX; i--)
	        {
		        arr[i,minY]=count++;
	        }
	        minY++;
        }

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write(String.Format("{0,3:D}", arr[i, j]));
            }
            Console.WriteLine();
        }
    }
}
