namespace jarai.tdd10.Adapter;

public class ApplePhone
{
    public void Charge(AppleCharger appleCharger)
    {
        int strom = appleCharger.LiefereStromViaLightning();

        Console.WriteLine($"ApplePhone lädt mit {strom} mA");
    }
}