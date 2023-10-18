namespace jarai.tdd7.MarsRoverKata;

public class Direction
{
    private readonly string _kompassDirection;


    static Direction()
    {
        North = new Direction(new Position(0, 1), "N");
        South = new Direction(new Position(0, -1), "S");
        East = new Direction(new Position(1, 0), "E");
        West = new Direction(new Position(-1, 0), "W");

        North.RightDirection = South.LeftDirection = East;
        North.LeftDirection = South.RightDirection = West;
        East.RightDirection = West.LeftDirection = South;
        East.LeftDirection = West.RightDirection = North;
    }

    public Direction(Position nextPositionOffset, string kompassDirection)
    {
        NextPositionOffset = nextPositionOffset;
        _kompassDirection = kompassDirection;
    }

    public Position NextPositionOffset { get; private set; }
    public Direction LeftDirection { get; set; }
    public Direction RightDirection { get; set; }

    public static Direction North { get; }

    public static Direction South { get; }

    public static Direction East { get; }

    public static Direction West { get; }

    public override string ToString()
    {
        return _kompassDirection;
    }
}