namespace jarai.tdd10.Adapter;

public class UsbChargerToAppleChagerAdapter : AppleCharger
{
    private readonly UsbCharger _usbCharger;

    public UsbChargerToAppleChagerAdapter(UsbCharger usbCharger)
    {
        _usbCharger = usbCharger;
    }

    public override int LiefereStromViaLightning()
    {
        // int strom = base.LiefereStromViaLightning(); // FALSCH!

        int strom = _usbCharger.LiefereStromViaUsb(); // RICHTIG, Adapter nutzt UsbCharger

        Console.WriteLine($"Adapter liefert {strom} mA via Lightning");

        return strom;
    }
}