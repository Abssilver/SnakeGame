using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int start, int end, int invariant, char symbol)
        {
            pointList = new List<Point>();
            for (int i = start; i < end; i++)
            {
                pointList.Add(new Point(invariant, i, symbol));
            }
        }
    }
}
