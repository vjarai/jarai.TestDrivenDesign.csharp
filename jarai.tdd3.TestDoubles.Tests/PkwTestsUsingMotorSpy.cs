using System.Diagnostics;
using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingMotorSpy
{
    [Fact]
    public void Fahren_erhoeht_Tachostand()
    {
        // Arrange
        var motorSpy = new MotorSpy();
        var target = new Pkw(motorSpy);

        // Act
        target.Fahren(100);

        // Assert
        Assert.Equal(100, target.Tachostand);

        // Spy fragen: Wie oft wurde der Motor beim Fahren() gestartet und gestoppt?
        Debug.WriteLine(motorSpy.AnlassenCounter);
        Debug.WriteLine(motorSpy.AnlassenCounter);

    }
}