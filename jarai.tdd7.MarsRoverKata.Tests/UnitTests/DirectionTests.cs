using Xunit;

namespace jarai.tdd7.MarsRoverKata.Tests.UnitTests;

public class DirectionTests
{
    [Fact]
    public void Left_of_North_should_West()
    {
        Assert.Equal(Direction.North.LeftDirection, Direction.West);
    }

    [Fact]
    public void Right_of_North_should_East()
    {
        Assert.Equal(Direction.North.RightDirection, Direction.East);
    }


    [Fact]
    public void Left_of_East_should_North()
    {
        Assert.Equal(Direction.East.LeftDirection, Direction.North);
    }

    [Fact]
    public void Right_of_East_should_South()
    {
        Assert.Equal(Direction.East.RightDirection, Direction.South);
    }


    [Fact]
    public void Left_of_West_should_South()
    {
        Assert.Equal(Direction.West.LeftDirection, Direction.South);
    }

    [Fact]
    public void Right_of_West_should_North()
    {
        Assert.Equal(Direction.West.RightDirection, Direction.North);
    }


    [Fact]
    public void Left_of_South_should_East()
    {
        Assert.Equal(Direction.South.LeftDirection, Direction.East);
    }

    [Fact]
    public void Right_of_South_should_West()
    {
        Assert.Equal(Direction.South.RightDirection, Direction.West);
    }
}