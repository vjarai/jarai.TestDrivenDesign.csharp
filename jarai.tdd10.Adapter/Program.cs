namespace jarai.tdd10.Adapter;

internal class Program
{
    private static void Main(string[] args)
    {
        var iphone = new ApplePhone();
        var appleCharger = new AppleCharger();
        iphone.Charge(appleCharger);

        var usbCharger = new UsbCharger();
        var adapter = new UsbChargerToAppleChagerAdapter(usbCharger);
        iphone.Charge(adapter);
    }
}