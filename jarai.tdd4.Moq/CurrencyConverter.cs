namespace jarai.tdd4.Moq;

public class CurrencyConverter
{
    private readonly IChangeRateService _changeRateService;

    public CurrencyConverter(IChangeRateService changeRateService)
    {
        _changeRateService = changeRateService;
    }

    public double Convert(string fromCurrency, string toCurrency, double amount)
    {
        CheckAmount(amount);

        double rate = GetRate(fromCurrency, toCurrency);
        CheckRate(rate);

        double converted = Convert(amount, rate);
        CheckConversionResult(converted);

        return converted;
    }

    private double Convert(double amount, double rate)
    {
        return amount * rate;
    }

    private void CheckConversionResult(double conversion)
    {
        if (conversion >= double.MaxValue)
            throw new ArgumentException("Result out of bound");
    }

    private double GetRate(string fromCurrency, string toCurrency)
    {
        try
        {
            return _changeRateService.GetChangeRate(fromCurrency, toCurrency);
        }
        catch (Exception unknownEx)
        {
            throw new ArgumentException("An unexpected error has been thrown during the conversion", unknownEx);
        }
    }

    internal void CheckRate(double rate)
    {
        if (rate < 0)
            throw new ArgumentException("Retrieved must be equal or greater than zero");
    }

    private static void CheckAmount(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must be equal or greater than zero");
    }
}