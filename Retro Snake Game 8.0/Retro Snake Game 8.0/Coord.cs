﻿namespace Retro_Snake_Game_8._0;

internal class Coord
{
    private int x;
    private int y;

    public int X { get { return x; } }
    public int Y { get { return y; } }

    public Coord(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override bool Equals(object? obj)
    {
        if ((obj == null) || !GetType().Equals(obj.GetType()))
            return false;

        Coord other = (Coord)obj;
        return x == other.x && y == other.y;
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }


}
