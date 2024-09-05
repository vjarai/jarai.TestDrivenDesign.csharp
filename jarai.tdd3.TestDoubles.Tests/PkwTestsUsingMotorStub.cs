using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingMotorStub
{
    [Fact]
    public void Fahren_erhoeht_Tachostand()
    {
        // Arrange
        var target = new Pkw(new MotorStub());

        // Act
        target.Fahren(100);

        // Assert
        Assert.Equal(100, target.Tachostand);
    }
}