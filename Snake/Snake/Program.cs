using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine top = new HorizontalLine(2, Console.BufferWidth-1, 0, '+');
            HorizontalLine bottom = new HorizontalLine(2, Console.BufferWidth-1, Console.BufferHeight-1, '+');
            VerticalLine left = new VerticalLine(0, Console.BufferHeight, 1, '+');
            VerticalLine right = new VerticalLine(0, Console.BufferHeight, Console.BufferWidth-1, '+');

            top.Draw();
            bottom.Draw();
            left.Draw();
            right.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            Console.ReadKey();
        }
    }
}
