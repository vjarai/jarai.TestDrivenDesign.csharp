namespace jarai.tdd10.Adapter;

public class AppleCharger
{
    public virtual int LiefereStromViaLightning()
    {
        int strom = 1000;

        Console.WriteLine($"AppleCharger liefert {strom} mA via Lightning");
        
        return strom;
    }
}