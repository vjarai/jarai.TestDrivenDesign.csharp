using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class LargeStraightRuleTests
{
    [Fact]
    public void CalculateScore_23456_Should_40()
    {
        // Arrange
        var wurf = new Wurf(2, 3, 4, 5, 6);
        var sut = new LargeStraightRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(40, actual);
    }
}