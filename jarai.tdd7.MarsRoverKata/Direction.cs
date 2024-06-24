namespace jarai.tdd7.MarsRoverKata;

public abstract class Direction
{
    private readonly string _kompassDirection;


    protected Direction( string kompassDirection)
    {
        _kompassDirection = kompassDirection;
    }


    public override string ToString()
    {
        return _kompassDirection;
    }

    public abstract Position GetNextPosition(Position position);

    public abstract Direction TurnLeft();

    public abstract Direction TurnRight();
}