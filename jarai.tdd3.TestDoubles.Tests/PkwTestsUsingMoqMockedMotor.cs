using Moq;
using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingMoqMockedMotor
{
    [Fact]
    public void Fahren_startet_Motor()
    {
        // Arrange
        var motorMock = new Mock<IMotor>(); // Generate mocked motor
        var target = new Pkw(motorMock.Object); // Inject mocked motor

        // Act
        target.Fahren(100);

        // Assert
        motorMock.Verify(m => m.Anlassen(), Times.Once); // Verify Expectation
    }

    [Fact]
    public void Fahren_stoppt_Motor()
    {
        // Arrange
        var motorMock = new Mock<IMotor>();
        var target = new Pkw(motorMock.Object);

        // Act
        target.Fahren(100);

        // Assert
        motorMock.Verify(m => m.Abstellen(), Times.Once);
    }
}