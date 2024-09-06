using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class SmallStraightRuleTests
{
    [Fact]
    public void CalculateScore_12634_Should_30()
    {
        // Arrange
        var wurf = new Wurf(1, 2, 6, 3, 4);
        var sut = new SmallStraightRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(30, actual);
    }
}