using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');
            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.Right);
            Snake snake = (Snake)fSnake;
            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);
            foreach (var fig in figures)
            {
                fig.Draw();
            }
            */

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

            FoodCreator foodCreator = new FoodCreator(Console.BufferWidth, Console.BufferHeight, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Console.CursorVisible=false;
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleMoving(key.Key);
                }
            }
        }
    }
}
