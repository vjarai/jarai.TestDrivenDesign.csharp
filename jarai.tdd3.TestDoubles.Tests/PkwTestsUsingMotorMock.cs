using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingMotorMock
{
    [Fact]
    public void Fahren_erhoeht_Tachostand()
    {
        // Arrange
        var motorMock = new MotorMock();
        var target = new Pkw(motorMock);

        // Act
        target.Fahren(100);

        // Assert
        Assert.True(motorMock._motorWurdeAngelassen);
        Assert.True(motorMock._motorWurdeAbgestellt);
    }
}