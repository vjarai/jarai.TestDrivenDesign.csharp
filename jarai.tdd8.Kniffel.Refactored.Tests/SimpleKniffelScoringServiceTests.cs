using Xunit;

namespace jarai.tdd8.KniffelRefactored.Tests;

public class SimpleKniffelScoringServiceTests
{
    // Simple Test using [Fact]
    [Fact]
    public void CalculateScore_non_parameterized_Test_Chance1()
    {
        // Arrange
        var wurf = new Wurf(1, 2, 3, 4, 5);
        var sut = new ParameterizedKniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, ScoreId.Chance);

        // Assert
        Assert.Equal(15, result);
    }


    // Simple Test using [Fact]
    [Fact]
    public void CalculateScore_non_parameterized_Test_Chance2()
    {
        // Arrange
        var wurf = new Wurf(5, 2, 3, 4, 5);
        var sut = new ParameterizedKniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, ScoreId.Chance);

        // Assert
        Assert.Equal(19, result);
    }
}