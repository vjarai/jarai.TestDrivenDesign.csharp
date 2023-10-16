using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class PkwTestsUsingFakeMotor
{
    [Fact]
    public void Fahren_erhoeht_Tachostand()
    {
        // Arrange
        var target = new Pkw(new FakeMotor());

        // Act
        target.Fahren(100);

        // Assert
        Assert.Equal(100, target.Tachostand);
    }
}