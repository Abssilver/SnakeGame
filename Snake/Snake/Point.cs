using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;
        public Point()
        { }
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }
        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.symbol = point.symbol;
        }
        public void Move(int offset, Direction direction)
        {
            switch (direction) 
            {
                case Direction.Left:
                    x -= offset;
                    break;
                case Direction.Right:
                    x += offset;
                    break;
                case Direction.Up:
                    y += offset;
                    break;
                case Direction.Down:
                    y -= offset;
                    break;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        public void Clear()
        {
            symbol = ' ';
            Draw();
        }
        public override string ToString()
        {
            return $"{x}, {y}, {symbol}";
        }
    }
}
