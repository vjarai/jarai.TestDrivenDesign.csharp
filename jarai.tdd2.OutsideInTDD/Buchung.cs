namespace jarai.tdd2.OutsideInTDD;

internal class Buchung
{
    public Buchung(decimal amount, DateTime date)
    {
        Amount = amount;
        Date = date;
    }

    public decimal Amount { get; }

    public DateTime Date { get; }

    public override string ToString()
    {
        return $"{Date} {Amount}";
    }
}