using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jarai.tdd2.OutsideInTDD.Tests.UnitTests;

[TestClass]
public class KontoTests
{
    [TestMethod]
    public void EinzahlenTest()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Einzahlen(100);
    }

    [TestMethod]
    public void AbhebenTest()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Abheben(50);
    }
}