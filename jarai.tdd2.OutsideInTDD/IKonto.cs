namespace jarai.tdd2.OutsideInTDD;

public interface IKonto
{
    public void Einzahlen(decimal einzuzahlenderBetrag);

    public void Abheben(decimal auszuzahlenderBetrag);

    public string ErstelleKontoauszug();
}