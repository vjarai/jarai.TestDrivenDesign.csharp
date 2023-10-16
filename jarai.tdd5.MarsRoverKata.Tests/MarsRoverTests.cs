using Xunit;

namespace jarai.tdd5.MarsRoverKata.Tests;

public class MarsRoverTests
{
    [Fact]
    public void ExecuteCommands_M_returns_0_1_N()
    {
        // Arrange
        var grid = new Grid();
        var target = new MarsRover(grid);

        // Act
        string actual = target.ExecuteCommands("M");

        // Assert

        Assert.Equal("0:1:N", actual);
    }
}