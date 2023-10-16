using Moq;
using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingGeneratedMotorMock
{
    [Fact]
    public void Fahren_startet_Motor()
    {
        // Arrange
        var motorMock = new Mock<IMotor>();
        motorMock.Setup(m => m.Anlassen());
        var target = new Pkw(motorMock.Object);

        // Act
        target.Fahren(100);

        // Assert
        motorMock.Verify(m => m.Anlassen(), Times.Once);
    }

    [Fact]
    public void Fahren_stoppt_Motor()
    {
        // Arrange
        var motorMock = new Mock<IMotor>();
        motorMock.Setup(m => m.Abstellen());
        var target = new Pkw(motorMock.Object);

        // Act
        target.Fahren(100);

        // Assert
        motorMock.Verify(m => m.Abstellen(), Times.Once);
    }
}