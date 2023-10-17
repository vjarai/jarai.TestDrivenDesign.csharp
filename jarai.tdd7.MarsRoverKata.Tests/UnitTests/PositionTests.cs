using Xunit;

namespace jarai.tdd6.MarsRoverKata.Tests.UnitTests;

public class PositionTests
{
    [Fact]
    public void EqualsTest()
    {
        // Arrange
        var pos1 = new Position(1, 2);
        var pos2 = new Position(1, 2);

        // Act
        bool actual = pos1.Equals(pos2);

        // Assert
        Assert.True(actual);
    }

    [Fact]
    public void OperatorPlusTest()
    {
        // Arrange
        var pos1 = new Position(1, 2);
        var pos2 = new Position(3, 4);

        // Act
        var actual = pos1 + pos2;

        // Assert
        Assert.Equal(new Position(4, 6), actual);
    }

    [Fact]
    public void OperatorPlusTest_overflow()
    {
        // Arrange
        var pos1 = new Position(1, 0);
        var pos2 = new Position(3, 10);

        // Act
        var actual = pos1 + pos2;

        // Assert
        Assert.Equal(new Position(4, 0), actual);
    }
}