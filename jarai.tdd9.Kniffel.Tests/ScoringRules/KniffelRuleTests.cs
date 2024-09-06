using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class KniffelRuleTests
{
    [Fact]
    public void CalculateScore_55555_Should_50()
    {
        // Arrange
        var wurf = new Wurf(5, 5, 5, 5, 5);
        var sut = new KniffelRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(50, actual);
    }
}