using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jarai.tdd2.OutsideInTDD.Tests.UnitTests;

[TestClass]
public class KontoTests
{
    [TestMethod]
    public void EinzahlenTest()
    {
        // Arrange
        var sut = new Konto();

        // Act
        sut.Einzahlen(100);
    }

    [TestMethod]
    public void AbhebenTest()
    {
        // Arrange
        var sut = new Konto();

        // Act
        sut.Abheben(50);
    }
}