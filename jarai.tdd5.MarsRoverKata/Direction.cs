namespace jarai.tdd5.MarsRoverKata;

public class Direction
{
    public Direction(Position nextPositionOffset, string kompass)
    {
        NextPositionOffset = nextPositionOffset;
        Kompass = kompass;
    }

    public Position NextPositionOffset { get; private set; }
    public string Kompass { get; }
    public Direction LeftDirection { get; set; }
    public Direction RightDirection { get; set; }


    public override string ToString()
    {
        return Kompass;
    }
}