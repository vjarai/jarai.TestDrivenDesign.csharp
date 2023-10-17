using Xunit;

namespace jarai.tdd6.MarsRoverKata.Tests.UnitTests;

public class GridTests
{
    [Fact]
    public void HasObstacleTest()
    {
        // Arrange
        var target = new Grid();
        target.AddObstacle(new Position(0, 0));

        // Act
        bool actual = target.HasObstacle(new Position(0, 0));

        // Assert
        Assert.True(actual);
    }
}