using System.Linq;
using FluentAssertions.Execution;
using jarai.tdd9.Kniffel.ScoringRules;
using Moq;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests;

public class SimpleKniffelScoringServiceTests
{
    [Fact]
    public void CalculateScorings_when_25345_shouldReturn_KleineStrasse_First()
    {
        // Arrange
        var wurf = new Wurf(2, 5, 3, 4, 5);
        var sut = new KniffelScoringService();

        // Act
        var actual = sut.CalculateScorings(wurf).First();

        // Bad Smell: Mehrere Asserts nacheinander (bricht beim ersten Fehler ab)
        Assert.Equal(ScoreId.SmallStraight, actual.ScoreId);
        Assert.Equal(30, actual.Score);

        // Besser: Assert.Multiple (führt alle Asserts aus)
        Assert.Multiple(
            () => Assert.Equal(ScoreId.SmallStraight, actual.ScoreId),
            () => Assert.Equal(30, actual.Score));

        // oder AssertionScope: https://fluentassertions.com/introduction
        using var scope = new AssertionScope();
        Assert.Equal(ScoreId.SmallStraight, actual.ScoreId);
        Assert.Equal(30, actual.Score);

        // Am Besten: Single Assert by using an actual object and its Equals method
        var expected = new ScoringResult(ScoreId.SmallStraight, 30);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateScorings_calls_Rule_CalculateScore()
    {
        // https://github.com/devlooped/moq/wiki/Quickstart

        // Arrange
        var wurf = new Wurf(1, 2, 3, 4, 5);

        var mockedRule = new Mock<ScoringRule>();
        mockedRule.Setup(r => r.CalculateScore(wurf)).Returns(15);

        var sut = new KniffelScoringService(new[] { mockedRule.Object });

        // Act
        var actual = sut.CalculateScorings(wurf).First();

        // Assert
        mockedRule.Verify(r => r.CalculateScore(wurf), Times.Once);
    }
}