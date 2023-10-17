namespace jarai.tdd4.Moq;

public interface IChangeRateService
{
    double GetChangeRate(string fromCurrency, string toCurrency);
}