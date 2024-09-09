namespace jarai.tdd0.Refresher;

public class Cabrio : Pkw
{
    public override  void Fahren()
    {
        VerdeckOeffnen();
        base.Fahren();
        VerdeckSchliessen();
    }

    public void VerdeckOeffnen()
    {
        Console.WriteLine("Verdeck öffnen");
    }

    public void VerdeckSchliessen()
    {
        Console.WriteLine("Verdeck schließen");
    }
}