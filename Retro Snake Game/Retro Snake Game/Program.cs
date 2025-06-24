using System;
using System.Collections.Generic;
using System.Threading;

namespace Retro_Snake_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord gridDimentions = new Coord(50, 20);
            Coord snakePos = new Coord(10, 1);

            Random rand = new Random();
            Coord applePos = new Coord(rand.Next(1, gridDimentions.X - 1), rand.Next(1, gridDimentions.Y - 1));

            int frameDelayMilli = 100;
            Direction movementDirection = Direction.Down;

            List<Coord> snakePosHistory = new List<Coord>();
            int tailLength = 1;

            int score = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Score " + score);
                snakePos.ApplyMovementDirection(movementDirection);

                for (int y = 0; y < gridDimentions.Y; y++)
                {
                    for (int x = 0; x < gridDimentions.X; x++)
                    {
                        Coord currentCoord = new Coord(x, y);

                        if (snakePos.Equals(currentCoord) || snakePosHistory.Contains(currentCoord))
                            Console.Write("■");
                        else if (applePos.Equals(currentCoord))
                            Console.Write("a");
                        else if (x == 0 || y == 0 || x == gridDimentions.X - 1 || y == gridDimentions.Y - 1)
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                if (snakePos.Equals(applePos))
                {
                    tailLength++;
                    score++;
                    applePos = new Coord(rand.Next(1, gridDimentions.X - 1), rand.Next(1, gridDimentions.Y - 1));
                }
                else if (snakePos.X == 0 || snakePos.Y == 0 || snakePos.X == gridDimentions.X - 1 || snakePos.Y == gridDimentions.Y - 1 || snakePosHistory.Contains(snakePos))
                {
                    score = 0;
                    tailLength = 1;
                    snakePos = new Coord(10, 1);
                    snakePosHistory.Clear();
                    movementDirection = Direction.Down;
                    continue;
                }

                snakePosHistory.Add(new Coord(snakePos.X, snakePos.Y));

                if (snakePosHistory.Count > tailLength)
                    snakePosHistory.RemoveAt(0);

                DateTime time = DateTime.Now;

                while ((DateTime.Now - time).Milliseconds < frameDelayMilli)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey().Key;

                        switch (key)
                        {
                            case ConsoleKey.LeftArrow:
                                movementDirection = Direction.Left;
                                break;
                            case ConsoleKey.UpArrow:
                                movementDirection = Direction.Up;
                                break;
                            case ConsoleKey.RightArrow:
                                movementDirection = Direction.Right;
                                break;
                            case ConsoleKey.DownArrow:
                                movementDirection = Direction.Down;
                                break;
                        }
                    }
                }
            }
        }
    }
}
