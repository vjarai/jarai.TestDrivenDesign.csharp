namespace jarai.tdd2.OutsideInTDD;

internal class Buchung
{
    public double Amount { get; }

    public string Date { get; }


    public Buchung(double amount, string date)
    {
        Amount = amount;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date} {Amount}";
    }
}