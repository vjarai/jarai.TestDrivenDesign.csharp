using System.Reflection.Metadata.Ecma335;

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
        string obstacle = "";
        string result = "";

        foreach (char command in commands)
        {
            switch (command)
            {
                case 'M':

                    var newPosition = _currentPosition.CalculateNextPosition(_currentDirection);

                    if (_grid.HasObstacle(newPosition))
                        obstacle = "O:";
                    else
                        _currentPosition = newPosition;

                    break;

                case 'L':
                    _currentDirection = _currentDirection.LeftDirection;
                    break;

                case 'R':
                    _currentDirection = _currentDirection.RightDirection;
                    break;

                default:
                    throw new ArgumentException($"Unknown command: {command}");
            }

            result = $"{obstacle}{_currentPosition}:{_currentDirection}";
            Logger(result);
        }

        return result;
    }
}