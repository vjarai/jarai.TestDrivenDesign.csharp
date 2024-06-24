using System.Runtime.CompilerServices;



namespace jarai.tdd7.MarsRoverKata;


public class MarsRover
{
    private readonly Grid _grid;

    private Direction _currentDirection;

    private Position _currentPosition;
    private bool _obstacleDetected;

    public Action<string> Logger { get; set; } = new(_ => { });

    public MarsRover()
    : this(new Grid(), new Position(0, 0), NorthDirection.Instance)
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
          _obstacleDetected = false;

          switch (command)
            {

                case 'M':
                    // Move one Step
                    Move();
                    break;

                case 'L':
                    // Turn Left
                    TurnLeft();
                    break;

                case 'R':
                    // Turn Right
                    TurnRight();
                    break;

                default:
                    throw new ArgumentException($"Unknown command: {command}");
            }

            result = $"{(_obstacleDetected?"O:":"")}{_currentPosition}:{_currentDirection}";
            Logger($"{command} => {result}");
        }

        return result;
    }

    private void TurnRight()
    {
        _currentDirection = _currentDirection.TurnRight();
    }

    private void TurnLeft()
    {
        _currentDirection = _currentDirection.TurnLeft();
    }

    internal Position Move()
    {
        var nextPosition =  _currentDirection.Move(_currentPosition);

        _obstacleDetected = _grid.HasObstacle(nextPosition);

        if (!_obstacleDetected)
            _currentPosition = nextPosition;

        return _currentPosition;
    }
}