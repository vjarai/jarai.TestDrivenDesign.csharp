using Xunit;

namespace jarai.tdd3.Stubbing.Tests;

public class PkwTests
{
    [Fact]
    public void Fahren_erhoeht_Tachostand()
    {
        // Arrange
        var target = new Pkw(new StubbedMotor());

        // Act
        target.Fahren(100);

        // Assert
        Assert.Equal(100, target.Tachostand);
    }
}