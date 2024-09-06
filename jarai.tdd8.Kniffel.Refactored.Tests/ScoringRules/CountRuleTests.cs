using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class CountRuleTests
{
    [Theory]
    [InlineData(3, 3, 3, 4, 2, 1, 0)]
    [InlineData(1, 2, 3, 4, 2, 2, 4)]
    [InlineData(3, 3, 3, 4, 2, 3, 9)]
    public void CalculateScore_ShouldReturn_SummmeDerZielwert(int a, int b, int c, int d, int e, int zielwert, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new CountRule(zielwert, ScoreId.Twos, "");

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(expected, actual);
    }
}