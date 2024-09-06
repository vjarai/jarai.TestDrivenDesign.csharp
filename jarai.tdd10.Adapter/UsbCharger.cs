namespace jarai.tdd10.Adapter;

public class UsbCharger
{
    public virtual int LiefereStromViaUsb()
    {
        var strom = 500;

        Console.WriteLine($"UsbCharger liefert {strom} mA via USB");

        return strom;
    }
}