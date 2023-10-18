using System.Runtime.CompilerServices;



namespace jarai.tdd7.MarsRoverKata;


public class MarsRover
{
    private readonly Grid _grid;

    private Direction _currentDirection;

    private Position _currentPosition;

    public Action<string> Logger { get; set; } = new(_ => { });

    public MarsRover()
    : this(new Grid(), new Position(0, 0), Direction.North)
    {

    }

    public MarsRover(Grid grid, Position startPosition, Direction startDirection)
    {
        _grid = grid;
        _currentPosition = startPosition;
        _currentDirection = startDirection;
    }

    public string ExecuteCommands(string commands)
    {
        string result = "";

        foreach (char command in commands)
        {
          bool obstacleDetected = false;

          switch (command)
            {

                case 'M':
                    // Move one Step
                    var nextPosition = CalculateNextPosition();

                    obstacleDetected = _grid.HasObstacle(nextPosition);

                    if (!obstacleDetected)
                        _currentPosition = nextPosition;

                    break;

                case 'L':
                    // Turn Left
                    _currentDirection = _currentDirection.LeftDirection;
                    break;

                case 'R':
                    // Turn Right
                    _currentDirection = _currentDirection.RightDirection;
                    break;

                default:
                    throw new ArgumentException($"Unknown command: {command}");
            }

            result = $"{(obstacleDetected?"O:":"")}{_currentPosition}:{_currentDirection}";
            Logger($"{command} => {result}");
        }

        return result;
    }

    internal Position CalculateNextPosition()
    {
        return _currentPosition + _currentDirection.NextPositionOffset;
    }
}