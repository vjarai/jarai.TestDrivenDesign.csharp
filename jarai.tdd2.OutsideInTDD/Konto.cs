namespace jarai.tdd2.OutsideInTDD;

public class Konto : IKonto
{
    private readonly List<Buchung> _buchungen = new();
    private readonly IKalenderService _kalenderService;


    public Konto(IKalenderService? kalenderService = null)
    {
        _kalenderService = kalenderService ?? new KalenderService();
    }

    public void Einzahlen(int einzuzahlenderBetrag)
    {
        _buchungen.Add(new Buchung(einzuzahlenderBetrag, _kalenderService.ToDay()));
    }

    public void Abheben(int auszuzahlenderBetrag)
    {
        _buchungen.Add(new Buchung(-auszuzahlenderBetrag, _kalenderService.ToDay()));
    }

    public string ErstelleKontoauszug()
    {
        double saldo = 0;
        var result = "Datum         Betrag     Saldo\n";

        foreach (var buchung in _buchungen)
        {
            saldo += buchung.Amount;
            result += $"{buchung.Date:d}  {buchung.Amount,8:F2}  {saldo,8:F2}\n";
        }

        return result;
    }
}