namespace jarai.tdd2.OutsideInTDD;

public class Konto : IKonto
{
    private readonly List<Buchung> _buchungen = new();
    private readonly IKalenderService _kalenderService;

    public decimal Kontostand { get; private set; } 

    public Konto(IKalenderService? kalenderService = null)
    {
        _kalenderService = kalenderService ?? new KalenderService();
    }

    public void Einzahlen(decimal einzuzahlenderBetrag)
    {
        Kontostand += einzuzahlenderBetrag;
        _buchungen.Add(new Buchung(einzuzahlenderBetrag, _kalenderService.Now()));
    }

    public void Abheben(decimal auszuzahlenderBetrag)
    {
        Kontostand -= auszuzahlenderBetrag;
        _buchungen.Add(new Buchung(-auszuzahlenderBetrag, _kalenderService.Now()));
    }

    public string ErstelleKontoauszug()
    {
        decimal saldo = 0;
        var result = "Datum         Betrag     Saldo\n";

        foreach (var buchung in _buchungen)
        {
            saldo += buchung.Amount;
            result += $"{buchung.Date:d}  {buchung.Amount,8:F2}  {saldo,8:F2}\n";
        }

        return result;
    }
}