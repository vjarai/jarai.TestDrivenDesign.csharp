using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingMotorMock
{
    [Fact]
    public void Fahren_startet_Motor()
    {
        // Arrange
        var motorMock = new MotorMock();
        var target = new Pkw(motorMock);

        // Act
        target.Fahren(100);

        // Assert
        Assert.True(motorMock.MotorWurdeAngelassen);
    }


    [Fact]
    public void Fahren_stoppt_Motor()
    {
        // Arrange
        var motorMock = new MotorMock();
        var target = new Pkw(motorMock);

        // Act
        target.Fahren(100);

        // Assert
        Assert.True(motorMock.MotorWurdeAbgestellt);
    }
}