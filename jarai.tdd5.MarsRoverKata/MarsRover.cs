namespace jarai.tdd5.MarsRoverKata;

public class MarsRover
{
    private readonly Grid _grid;

    private Direction _currentDirection;

    private Position _currentPosition = new(0, 0);

    public MarsRover(Grid grid)
    {
        _grid = grid;

        var north = new Direction(new Position(0, 1), "N");
        var south = new Direction(new Position(0, -1), "S");
        var east = new Direction(new Position(1, 0), "E");
        var west = new Direction(new Position(-1, 0), "W");

        north.LeftDirection = west;
        north.RightDirection = east;

        south.LeftDirection = east;
        south.RightDirection = west;

        east.LeftDirection = north;
        east.RightDirection = south;

        west.LeftDirection = south;
        west.RightDirection = north;

        _currentDirection = north;
    }

    public string ExecuteCommands(string commands)
    {
        foreach (char command in commands)
            switch (command)
            {
                case 'M':

                    var newPosition = _currentPosition.CalculateNextPosition(_currentDirection);

                    if (!_grid.HasObstacle(newPosition))
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

        return $"{_currentPosition}:{_currentDirection}";
    }
}