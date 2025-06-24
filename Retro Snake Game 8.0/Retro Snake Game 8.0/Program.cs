using Retro_Snake_Game_8._0;

Coord gridDimentions = new Coord(50, 20);
Coord snakePos = new Coord(10, 1);

Random rand = new Random();
Coord applePos = new Coord(rand.Next(1, gridDimentions.X - 1), rand.Next(1, gridDimentions.Y - 1));

for (int y = 0; y < gridDimentions.Y; y++)
{
    for (int x = 0; x < gridDimentions.X; x++)
    {
        Coord currentCoord = new Coord(x, y);

        if (snakePos.Equals(currentCoord))
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