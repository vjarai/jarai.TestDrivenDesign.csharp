﻿namespace jarai.tdd7.MarsRoverKata;

public class NorthDirection : Direction
{
    private NorthDirection() : base("N")
    {
    }

    public static NorthDirection Instance { get; } = new();

    public override Position Move(Position currentPosition)
    {
        return new Position(currentPosition.X, currentPosition.Y + 1);
    }

    public override Direction TurnLeft()
    {
        return WestDirection.Instance;
    }

    public override Direction TurnRight()
    {
        return EastDirection.Instance;
    }
}