using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(6, 10, '&');
            Point p4 = new Point(3, 170, '?');
            List<char> symbolList = new List<char>() { p1.symbol, p2.symbol, p3.symbol, p4.symbol };
            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);

            Console.ReadKey();
        }
    }
}
