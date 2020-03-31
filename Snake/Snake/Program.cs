using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine top = new HorizontalLine(2, 79, 0, '+');
            HorizontalLine bottom = new HorizontalLine(2, 79, 24, '+');
            VerticalLine left = new VerticalLine(0, 25, 1, '+');
            VerticalLine right = new VerticalLine(0, 25, 79, '+');

            top.Draw();
            bottom.Draw();
            left.Draw();
            right.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();
            Console.ReadKey();
        }
    }
}
