﻿using System.Linq;
using Xunit;

namespace jarai.tdd8.KniffelRefactored.Tests;

public class SimpleKniffelScoringServiceTests
{
    [Fact]
    public void CalculateScore_Chance_Should_15()
    {
        // Arrange
        var wurf = new Wurf(1, 2, 3, 4, 5);
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(ScoreId.Chance, wurf);

        // Assert
        Assert.Equal(15, result);
    }


    [Fact]
    public void CalculateScore_Chance_Should_19()
    {
        // Arrange
        var wurf = new Wurf(5, 2, 3, 4, 5);
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(ScoreId.Chance, wurf);

        // Assert
        Assert.Equal(19, result);
    }

    [Fact]
    public void CalculateScorings_when_5_2_4_4_5_shouldReturn_KleineStrasse_First()
    {
        // Arrange
        var wurf = new Wurf(5, 2, 3, 4, 5);
        var sut = new KniffelScoringService();
        var expected = new ScoringResult(ScoreId.SmallStraight, 30);

        // Act
        var result = sut.CalculateScorings(wurf).First();

        // Bad Smell: Multiple Asserts
        Assert.Equal(ScoreId.SmallStraight, result.ScoreId);
        Assert.Equal(30, result.Result);

        // Besser: Single Assert by using result object and its Equals method
        Assert.Equal(expected, result);
    }
}