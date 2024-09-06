using System.Linq;
using jarai.tdd9.Kniffel.ScoringRules;
using Moq;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests;

public class SimpleKniffelScoringServiceTests
{
    [Fact]
    public void CalculateScorings_when_5_2_4_4_5_shouldReturn_KleineStrasse_First()
    {
        // Arrange
        var wurf = new Wurf(5, 2, 3, 4, 5);
        var sut = new KniffelScoringService();

        // Act
        var actual = sut.CalculateScorings(wurf).First();

        // Bad Smell: Multiple Asserts
        Assert.Equal(ScoreId.SmallStraight, actual.ScoreId);
        Assert.Equal(30, actual.Score);

        // Besser: Single Assert by using actual object and its Equals method
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

        var sut = new KniffelScoringService(mockedRule.Object);

        // Act
        var actual = sut.CalculateScorings(wurf).First();

        // Assert
        mockedRule.Verify(r => r.CalculateScore(wurf), Times.Once);
    }
}