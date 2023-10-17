using Moq;
using Xunit;

namespace jarai.tdd4.Moq.Tests;

public class CurrencyConverterTests
{
    [Theory]
    [InlineData("USD", "USD", 1.0, 1.0)]
    [InlineData("USD", "EUR", .8, .8)]
    [InlineData("EUR", "USD", 1.2, 1.2)]
    [InlineData("EUR", "EUR", 1.0, 1.0)]
    public void Convert_ValidCurrencies(string fromCurrency, string toCurrency, double rate, double result)
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
        Assert.Equal(result, actual, 4);
    }

    [Fact]
    public void Convert_InvalidCurrency_ThrowsArgumentException()
    {
        // Arrange
        var changeRateService = new Mock<IChangeRateService>();

        changeRateService.Setup(x => x.GetChangeRate(It.IsAny<string>(), It.IsAny<string>()))
            .Throws(new ArgumentException("Invalid currency"));

        var currencyConverter = new CurrencyConverter(changeRateService.Object);

        // Act
        var exception = Record.Exception(() => currencyConverter.Convert("<unknown>", "<unknown>", 1.0));

        // Assert
        Assert.IsType<ArgumentException>(exception);
    }
}