using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class KniffelRuleTests
{
    [Theory]
    [InlineData(5, 5, 5, 5, 5, 50)] // Positiv Test
    [InlineData(5, 5, 5, 5, 1, 0)] // Negativ Test
    public void CalculateScore_Should_50_or_0(int a, int b, int c, int d, int e, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new KniffelRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(expected, actual);
    }
}