using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class LargeStraightRuleTests
{
    [Theory]
    [InlineData(2, 3, 4, 5, 6, 40)] // Positiv Test
    [InlineData(1, 3, 4, 5, 1, 0)] // Negativ Test
    public void CalculateScore_Should_40_or_0(int a, int b, int c, int d, int e, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new LargeStraightRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(expected, actual);
    }
}