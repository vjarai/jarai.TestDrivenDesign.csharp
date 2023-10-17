namespace jarai.tdd6.MarsRoverKata;

public class Direction
{
    private readonly string _kompass;

    public Direction(Position nextPositionOffset, string kompass)
    {
        NextPositionOffset = nextPositionOffset;
        _kompass = kompass;
    }

    public Position NextPositionOffset { get; private set; }
    public Direction LeftDirection { get; set; }
    public Direction RightDirection { get; set; }


    public override string ToString()
    {
        return _kompass;
    }
}