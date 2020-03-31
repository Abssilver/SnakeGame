using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>(); 
            
            HorizontalLine top = new HorizontalLine(2, mapWidth - 1, 0, '+');
            HorizontalLine bottom = new HorizontalLine(2, mapWidth - 1, mapHeight - 1, '+');
            VerticalLine left = new VerticalLine(0, mapHeight - 1, 1, '+');
            VerticalLine right = new VerticalLine(0, mapHeight - 1, mapWidth - 1, '+');

            wallList.Add(top);
            wallList.Add(bottom);
            wallList.Add(left);
            wallList.Add(right);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
