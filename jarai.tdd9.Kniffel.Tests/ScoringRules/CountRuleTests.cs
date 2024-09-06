using jarai.tdd9.Kniffel.ScoringRules;
using jarai.tdd9.Kniffel.Tests.TestDataSources;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests.ScoringRules;

public class CountRuleTests
{
    [Theory]
    [InlineData(3, 3, 3, 4, 2, 2)]
    [InlineData(1, 2, 3, 4, 2, 4)]
    [InlineData(3, 2, 3, 2, 2, 6)]
    public void CalculateScore_ShouldReturn_SummmeDerZielwert(int a, int b, int c, int d, int e, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new CountRule(2, ScoreId.Twos, "");

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(expected, actual);
    }


    // Parameterized Test using ClassData
    [Theory]
    [ClassData(typeof(ScoringServiceTestDataSource))]
    public void CalculateScore_parameterized_Test_using_ClassDataSource(int a, int b, int c, int d, int e, ScoreId scoreId, int zielwert, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new CountRule(zielwert, scoreId, "");

        // Act
        int actual = sut.CalculateScore(wurf);

        // Assert
        Assert.Equal(expected, actual);
    }
}