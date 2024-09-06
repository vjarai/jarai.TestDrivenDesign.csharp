using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class FourOfAKindRuleTests
{
    [Fact]
    public void CalculateScore_55155_Should_21()
    {
        // Arrange
        var wurf = new Wurf(5, 5, 1, 5, 5);
        var sut = new FourOfAKindRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(21, actual);
    }

    [Fact]
    public void CalculateScore_55153_Should_0()
    {
        // Arrange
        var wurf = new Wurf(5, 5, 1, 5, 3);
        var sut = new FourOfAKindRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(0, actual);
    }
}