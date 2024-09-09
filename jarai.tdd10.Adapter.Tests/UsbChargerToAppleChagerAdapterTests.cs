using Moq;
using Xunit;

namespace jarai.tdd10.Adapter.Tests;

public class UsbChargerToAppleChagerAdapterTests
{
    [Fact]
    public void LiefereStromViaLightningTest()
    {
        // Arrange
        var iphone = new ApplePhone();
        var usbChargerMock = new Mock<UsbCharger>();
        var adapter = new UsbChargerToAppleChagerAdapter(usbChargerMock.Object);

        // Act
        iphone.Charge(adapter);
        // int strom = adapter.LiefereStromViaLightning();

        // Assert
        usbChargerMock.Verify(charger => charger.LiefereStromViaUsb(), Times.Once);
    }
}