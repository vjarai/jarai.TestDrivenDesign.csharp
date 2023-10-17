namespace jarai.tdd7.MarsRoverKata;

public class Position
{
    private const int Max = 10;
    private readonly int _x;
    private readonly int _y;

    public Position(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public static Position operator +(Position lhs, Position rhs)
    {
        return new Position((lhs._x + rhs._x) % Max, (lhs._y + rhs._y) % Max);
    }

    public override bool Equals(object obj)
    {
        if (obj is Position other)
            return _x == other._x && _y == other._y;

        return false;
    }

    public Position CalculateNextPosition(Direction direction)
    {
        return this + direction.NextPositionOffset;
    }

    public override string ToString()
    {
        return $"{_x}:{_y}";
    }
}