using Xunit;

namespace jarai.tdd7.MarsRoverKata.Tests.UnitTests;

public class MarsRoverTest
{
    [Fact]
    public void MoveTest()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        var actual = target.Move();

        // Assert
        Assert.Equal(new Position(0, 1), actual);
    }
}