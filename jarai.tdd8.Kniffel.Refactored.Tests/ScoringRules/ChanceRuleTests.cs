﻿using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class ChanceRuleTests
{
    [Fact]
    public void CalculateScore_12345_Should_15()
    {
        // Arrange
        var wurf = new Wurf(1, 2, 3, 4, 5);
        var sut = new ChanceRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(15, actual);
    }

    [Fact]
    public void CalculateScore_52345_Should_19()
    {
        // Arrange
        var wurf = new Wurf(5, 2, 3, 4, 5);
        var sut = new ChanceRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(19, actual);
    }
}