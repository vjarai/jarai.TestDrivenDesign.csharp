﻿using jarai.tdd9.Kniffel.ScoringRules;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class SmallStraightRuleTests
{
    [Theory]
    [InlineData(2, 3, 4, 1, 6, 30)] // Positiv Test
    [InlineData(1, 3, 4, 1, 1, 0)]  // Negativ Test
    public void CalculateScore_Should_30_or_0(int a, int b, int c, int d, int e, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new SmallStraightRule();

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(expected, actual);
    }
}