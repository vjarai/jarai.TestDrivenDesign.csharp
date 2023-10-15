using ApprovalTests;
using Xunit;

namespace jarai.tdd2.OutsideInTDD.Tests.AcceptanceTests
{
    public class KontoApprovalTests
    {
        [Fact()]
        public void ErstelleKontoauszugApprovalTest()
        {
            // Arrange
            var target = new Konto();

            // Act
           string kontoauszug = target.ErstelleKontoauszug();

            // Assert
            Approvals.Verify(kontoauszug);
        }
    }
}