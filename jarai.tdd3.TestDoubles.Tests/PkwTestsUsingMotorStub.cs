using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingMotorStub
{
    [Fact]
    public void Fahren_erhoeht_Tachostand()
    {
        // Arrange
        var motorStub = new MotorStub();
        motorStub.Drehzahl = 1000;

        var target = new Pkw(motorStub);

        // Act
        target.Fahren(100);

        // Assert
        Assert.Equal(100, target.Tachostand);
    }
}