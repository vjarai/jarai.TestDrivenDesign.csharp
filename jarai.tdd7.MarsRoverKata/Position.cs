namespace jarai.tdd7.MarsRoverKata;

public class Position
{
    private const int Max = 10;
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x % 10;
        Y = y % 10;
    }

    public override bool Equals(object obj)
    {
        if (obj is Position other)
            return X == other.X && Y == other.Y;

        return false;
    }

    public override string ToString()
    {
        return $"{X}:{Y}";
    }
}