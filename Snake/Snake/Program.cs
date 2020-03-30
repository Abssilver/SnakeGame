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
            LineDrawer line = new LineDrawer(4, 10, true, 9, '*');
            line.Draw();
            LineDrawer line2 = new LineDrawer(6, 12, false, 10, '*');
            line2.Draw();
            Console.ReadKey();
        }
    }
}
