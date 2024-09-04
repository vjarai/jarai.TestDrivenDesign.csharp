using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace jarai.tdd8.KniffelRefactored.Tests;

public class KniffelScoringServiceTests
{
    // Simple Test using [Fact]
    [Fact]
    public void CalculateScore_non_parameterized_Test()
    {
        // Arrange
        var wurf = new Wurf(1, 2, 3, 4, 5);
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, ScoringRuleId.Chance);

        // Assert
        Assert.Equal(15, result);
    }


    // Parameterized Test using InlineData
    [Theory]
    [InlineData(1, 1, 1, 1, 1, ScoringRuleId.Chance, 5)]
    [InlineData(4, 4, 4, 3, 3, ScoringRuleId.FullHouse, 25)]
    public void CalculateScore_parameterized_Test_using_InlineData(int a, int b, int c, int d, int e, ScoringRuleId rule, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, rule);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using ClassData
    [Theory]
    [ClassData(typeof(TestDataSourceClass))]
    public void CalculateScore_parameterized_Test_using_ClassDataSource(int a, int b, int c, int d, int e, ScoringRuleId rule, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, rule);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using strongly typed MemberData  
    [Theory]
    [MemberData(nameof(StronglyTypedTestDataSourceMemberFunction))]
    public void CalculateScore_parameterized_Test_using_strongly_typed_MemberData(Wurf wurf, ScoringRuleId rule, int expected)
    {
        // Arrange
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, rule);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using MemberData 
    [Theory]
    [MemberData(nameof(TestDataSourceMemberFunction))]
    public void CalculateScore_parameterized_Test_using_MemberData(int a, int b, int c, int d, int e, ScoringRuleId rule, int expected)
    {
        // Arrange
        var sut = new KniffelScoringService();
        var wurf = new Wurf(a, b, c, d, e);

        // Act
        int result = sut.CalculateScore(wurf, rule);

        // Assert
        Assert.Equal(expected, result);
    }

    /// <summary>
    ///     Static Member Function which returns the data for the [MemberData] parametrized Test
    /// </summary>
    public static IEnumerable<object[]> TestDataSourceMemberFunction()
    {
        return new List<object[]>
        {
            new object[] { 1, 2, 3, 4, 3, ScoringRuleId.SmallStraight, 30 },
            new object[] { 1, 2, 3, 1, 3, ScoringRuleId.SmallStraight, 0 },
            new object[] { 2, 3, 4, 5, 6, ScoringRuleId.LargeStraight, 40 }
        };
    }


    /// <summary>
    ///     Static Member Function which returns the data for the [MemberData] parametrized Test
    /// </summary>
    public static TheoryData<Wurf, ScoringRuleId, int> StronglyTypedTestDataSourceMemberFunction()
    {
        return new TheoryData<Wurf, ScoringRuleId, int>
        {
            { new Wurf(6, 6, 6, 3, 1), ScoringRuleId.ThreeOfAKind, 22 },
            { new Wurf(3, 3, 3, 3, 5), ScoringRuleId.FourOfAKind, 17 }
        };
    }

    /// <summary>
    ///     External Class which returns the data for the [ClassData] parameterized Test
    /// </summary>
    public class TestDataSourceClass : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new()
        {
            new object[] { 6, 6, 6, 6, 6, ScoringRuleId.Sixes, 30 },
            new object[] { 5, 5, 5, 5, 5, ScoringRuleId.Fives, 25 },
            new object[] { 4, 4, 4, 4, 5, ScoringRuleId.Fours, 16 },
            new object[] { 3, 3, 3, 4, 5, ScoringRuleId.Threes, 9 },
            new object[] { 2, 2, 1, 4, 2, ScoringRuleId.Twos, 6 },
            new object[] { 1, 2, 1, 4, 1, ScoringRuleId.Ones, 3 }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}