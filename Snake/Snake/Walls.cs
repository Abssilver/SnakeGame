using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        int mapWidth, mapHeight;
        public Walls(int _mapWidth, int _mapHeight)
        {
            wallList = new List<Figure>();
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            HorizontalLine top = new HorizontalLine(2, _mapWidth - 1, 0, '+');
            HorizontalLine bottom = new HorizontalLine(2, _mapWidth - 1, _mapHeight - 1, '+');
            VerticalLine left = new VerticalLine(0, _mapHeight, 1, '+');
            VerticalLine right = new VerticalLine(0, _mapHeight, _mapWidth - 1, '+');

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
        public void EndGame()
        {
            HorizontalLine endGameTop = new HorizontalLine
                (Console.BufferWidth / 4, Console.BufferWidth * 3 / 4, Console.BufferHeight / 2 - 2, '=');
            endGameTop.Draw();
            string endGameText = "G A M E    O V E R";
            Credits(endGameText, Console.BufferWidth / 2 - endGameText.Length / 2, Console.BufferHeight / 2 - 1);
            string endGameAuthorText = "Author: Remizov Pavel";
            Credits(endGameAuthorText, Console.BufferWidth / 2 - endGameAuthorText.Length / 2, Console.BufferHeight / 2);
            string endGameSpecialThanksText = "Special thanks to GeekBrains";
            Credits(endGameSpecialThanksText, Console.BufferWidth / 2 - endGameSpecialThanksText.Length / 2, Console.BufferHeight / 2 + 1);
            string endGameExtra = "Student speciality: C# Developer";
            Credits(endGameExtra, Console.BufferWidth / 2 - endGameExtra.Length / 2, Console.BufferHeight / 2 + 2);
            HorizontalLine endGameBottom = new HorizontalLine
                (Console.BufferWidth / 4, Console.BufferWidth * 3 / 4, Console.BufferHeight / 2 + 3, '=');
            endGameBottom.Draw();
        }
        void Credits(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(msg);
        }
    }
}
