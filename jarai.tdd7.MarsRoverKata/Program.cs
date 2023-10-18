namespace jarai.tdd7.MarsRoverKata;

public class Program
{
    public static void Main(string[] args)
    {
        var grid = new Grid();
        grid.AddObstacle(new Position(0, 4));

        var marsRover = new MarsRover(grid, new Position(0, 0), Direction.North)
        {
            Logger = Console.WriteLine
        };

        marsRover.ExecuteCommands("MMMM");

    }
}