using Xunit;

namespace jarai.tdd2.OutsideInTDD.Tests.UnitTests;


public class KontoTests
{
    [Fact]
    public void EinzahlenTest()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Einzahlen(100);
    }

    [Fact]
    public void AbhebenTest()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Abheben(50);
    }
}