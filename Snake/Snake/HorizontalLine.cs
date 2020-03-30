using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int start, int end, int invariant, char symbol)
        {
            pointList = new List<Point>();
            for (int i = start; i < end; i++)
            {
                pointList.Add(new Point(i, invariant, symbol));
            }
        }
    }
}
