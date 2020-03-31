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

            Walls walls = new Walls(Console.BufferWidth, Console.BufferHeight);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(Console.BufferWidth, Console.BufferHeight, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Console.CursorVisible=false;
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
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
            walls.EndGame();
            Console.ReadLine();
        }
    }
}
