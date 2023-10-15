using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class MotorTests
{
    [Fact]
    public void AnlassenTest()
    {
        // Arrange
        var target = new Motor();

        // Act
        target.Anlassen();

        // Assert
        Assert.True(target.Drehzahl > 0);
    }

    [Fact]
    public void AbstellenTest()
    {
        // Arrange
        var target = new Motor();

        // Act
        target.Abstellen();

        // Assert
        Assert.True(target.Drehzahl == 0);
    }
}