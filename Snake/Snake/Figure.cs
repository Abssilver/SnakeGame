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
        internal bool IsHit(Figure figure)
        {
            foreach (var point in pointList)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (var _point in pointList)
            {
                if (_point.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
