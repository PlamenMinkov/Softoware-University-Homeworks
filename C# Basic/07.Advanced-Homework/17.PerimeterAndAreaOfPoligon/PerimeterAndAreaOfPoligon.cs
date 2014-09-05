using System;
using System.Collections.Generic;
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
class PerimeterAndAreaOfPoligon
{
    static double PolygonPerimeter(Point[] perimeter)
    {
        double finalPerimeter = 0;
        for (int i = 0; i < perimeter.Length - 1; i++)
        {
            finalPerimeter += Math.Sqrt((perimeter[i + 1].X-perimeter[i].X)*(perimeter[i + 1].X-perimeter[i].X)
                              +(perimeter[i + 1].Y-perimeter[i].Y)*(perimeter[i + 1].Y-perimeter[i].Y));
        }
        return finalPerimeter;
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Point[] perimeter=new Point[n];
        for (int i = 0; i < n; i++)
        {
            string pointCoordinates = Console.ReadLine();
            string[] points = pointCoordinates.Split(' ');
            perimeter[i] = new Point() { X = int.Parse(points[0]), Y = int.Parse(points[1]) };
        }
        double fPer = PolygonPerimeter(perimeter);
        double area = (3.41 * 3.41) / (4 * Math.PI);

        Console.WriteLine(@"
Perimeter:{0}
Area:{1}",fPer,area);
    }
}
