using Moq;
using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

// https://www.codemag.com/Article/2305041/Using-Moq-A-Simple-Guide-to-Mocking-for-.NET

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


    [Fact]
    public void Fahren_startet_und_stoppt_Motor()
    {
        // Arrange
        var motorMock = new Mock<IMotor>();
        motorMock.Setup(m => m.Anlassen()); // Setup Expectation (eigentlich ein Assert)
        motorMock.Setup(m => m.Abstellen()); // Setup Expectation (eigentlich ein Assert)

        var target = new Pkw(motorMock.Object);

        // Act
        target.Fahren(100);

        // SINGLE Assert mit VerifyAll (besser 2 einzelne Asserts ???)
        motorMock.VerifyAll(); // Verify Expectations
    }
}