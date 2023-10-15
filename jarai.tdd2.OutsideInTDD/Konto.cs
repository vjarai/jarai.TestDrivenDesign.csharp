namespace jarai.tdd2.OutsideInTDD;

public class Konto : IKonto
{
    private readonly List<Buchung> _buchungen = new();

    public void Einzahlen(int einzuzahlenderBetrag)
    {
        _buchungen.Add(new Buchung(einzuzahlenderBetrag, "01.01.2023"));
    }

    public void Abheben(int auszuzahlenderBetrag)
    {
        _buchungen.Add(new Buchung(-auszuzahlenderBetrag, "01.01.2023"));
    }

    public string ErstelleKontoauszug()
    {
        double saldo = 0;
        var result = "Datum         Betrag     Saldo\n";

        foreach (var buchung in _buchungen)
        {
            saldo += buchung.Amount;
            result += $"{buchung.Date}  {buchung.Amount,8:F2}  {saldo,8:F2}\n";
        }

        return result;
    }
}