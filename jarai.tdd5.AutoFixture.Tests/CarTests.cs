using AutoFixture;
using Xunit;

namespace jarai.tdd5.AutoFixture.Tests;

public class CarTests
{
    [Fact]
    public void AssignOwnerTest()
    {
        // Arrange
        var fixture = new Fixture();
        var car = fixture.Create<Car>();

        // Assert
        Assert.NotNull(car.Owner.Pets);
    }
}