namespace jarai.tdd2.OutsideInTDD;

internal class Buchung
{
    public Buchung(double amount, DateTime date)
    {
        Amount = amount;
        Date = date;
    }

    public double Amount { get; }

    public DateTime Date { get; }

    public override string ToString()
    {
        return $"{Date} {Amount}";
    }
}