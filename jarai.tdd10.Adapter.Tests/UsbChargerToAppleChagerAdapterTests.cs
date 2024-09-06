using Xunit;
using jarai.tdd10.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace jarai.tdd10.Adapter.Tests
{
    public class UsbChargerToAppleChagerAdapterTests
    {
        [Fact()]
        public void LiefereStromViaLightningTest()
        {
            // Arrange
            var iphone = new ApplePhone();
            var usbChargerMock = new Mock<UsbCharger>();
            var adapter = new UsbChargerToAppleChagerAdapter(usbChargerMock.Object);

            // Act
            iphone.Charge(adapter);

            // Assert
            usbChargerMock.Verify( charger => charger.LiefereStromViaUsb(), Times.Once);
        }
    }
}