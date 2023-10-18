using Xunit;

namespace jarai.tdd7.MarsRoverKata.Tests.UnitTests;

public class MarsRoverTest
{
    [Fact]
    public void CalculateNextPositionTest()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        var actual = target.CalculateNextPosition();

        // Assert
        Assert.Equal(new Position(0,1), actual);
    }
}