using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> pointList;
        public virtual void Draw()
        {
            foreach (var point in pointList)
            {
                point.Draw();
            }
        }
    }
}
