using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class FullHouseRuleTests
{
    [Fact]
    public void CalculateScore_33355_Should_21()
    {
        // Arrange
        var wurf = new Wurf(3, 3, 3, 5, 5);
        var sut = new FullHouseRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(25, actual);
    }
}