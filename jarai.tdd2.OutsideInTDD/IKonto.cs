namespace jarai.tdd2.OutsideInTDD;

public interface IKonto
{
    public void Einzahlen(int einzuzahlenderBetrag);

    public void Abheben(int auszuzahlenderBetrag);

    public string ErstelleKontoauszug();
}