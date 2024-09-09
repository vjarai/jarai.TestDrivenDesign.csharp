using Moq;
using Xunit;
using Assert = Xunit.Assert;

namespace jarai.tdd4.Moq.Tests;

public class CurrencyConverterTests
{
    [Theory]
    [InlineData("USD", "USD", 1.0, 1.0)]
    [InlineData("USD", "EUR", .8, .8)]
    [InlineData("EUR", "USD", 1.2, 1.2)]
    [InlineData("EUR", "EUR", 1.0, 1.0)]
    public void Convert_ValidCurrencies(string fromCurrency, string toCurrency, double rate, double expected)
    {
        // Arrange
        var changeRateService = new Mock<IChangeRateService>();

        // changeRateService.SetupAllProperties();  // Alle Properties werden automatisch gemockt

        changeRateService.Setup(x => x.GetChangeRate(
                It.Is<string>(a => a == fromCurrency),
                It.Is<string>(a => a == toCurrency)))
            .Returns(rate);

        var currencyConverter = new CurrencyConverter(changeRateService.Object);

        // Act
        double actual = currencyConverter.Convert(fromCurrency, toCurrency, 1.0);


        // Assert
        Assert.Equal(expected, actual, 4);

        //changeRateService.VerifyAll();
    }

    [Fact]
    public void Convert_InvalidCurrency_ThrowsArgumentException()
    {
        // Arrange
        var changeRateService = new Mock<IChangeRateService>();

        changeRateService.Setup(x => x.GetChangeRate(It.IsAny<string>(), It.IsAny<string>()))
            .Throws(new ArgumentException("Invalid currency"));

        var target = new CurrencyConverter(changeRateService.Object);

        // Act
        Assert.Throws<ArgumentException>(() => target.Convert("<unknown>", "<unknown>", 1.0));
    }

    [Fact(Skip = "Interner Test")]
    public void CheckRateTest()
    {
        // Das Testen interner Methoden ist in der Regel ein Bad smell!
        // Durch ein InternalsVisibleTo Attribut in der AssemblyInfo.cs ist es in Ausnahmefällen prinzipiell möglich 

        // Arrange
        var sut = new CurrencyConverter(new Mock<IChangeRateService>().Object);

        // Act


        // Assert
        Assert.Throws<ArgumentException>(() => sut.CheckRate(-10));
    }
}