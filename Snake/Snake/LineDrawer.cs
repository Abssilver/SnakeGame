using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class LineDrawer
    {
        List<Point> pointList;
        public LineDrawer(int start, int end, bool isHorizontal, int invariant, char symbol) 
        {
            pointList = new List<Point>();
            for (int i = start; i < end; i++)
            {
                if (isHorizontal)
                    pointList.Add(new Point(i, invariant, symbol));
                else
                    pointList.Add(new Point(invariant, i, symbol));
            }
        }
        public void Draw()
        {
            foreach (var point in pointList)
            {
                point.Draw();
            }
        }
    }
}
