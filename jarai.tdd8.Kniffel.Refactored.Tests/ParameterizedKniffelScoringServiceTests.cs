using System.Collections.Generic;
using jarai.tdd8.KniffelRefactored.Tests.TestDataSources;
using Xunit;

// xUnit.net is a free, open source, community-focused unit testing tool for the .NET Framework.
// https://xunit.net/#current-releases

// Moq is a popular .NET mocking library for C#. This is a quick start guide to using Moq.
// https://github.com/devlooped/moq/wiki/Quickstart

namespace jarai.tdd8.KniffelRefactored.Tests;

public class ParameterizedKniffelScoringServiceTests
{
    private readonly KniffelScoringService _sut;

    public ParameterizedKniffelScoringServiceTests()
    {
        // Fixture setup
        _sut = new KniffelScoringService();
    }

    // Parameterized Test using InlineData
    [Theory]
    [InlineData(1, 1, 1, 1, 1, ScoreId.Chance, 5)]
    [InlineData(4, 4, 4, 3, 3, ScoreId.FullHouse, 25)]
    public void CalculateScore_parameterized_Test_using_InlineData(int a, int b, int c, int d, int e, ScoreId scoreId, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);

        // Act
        int result = _sut.CalculateScore(scoreId, wurf);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using ClassData
    [Theory]
    [ClassData(typeof(ScoringServiceTestDataSource))]
    public void CalculateScore_parameterized_Test_using_ClassDataSource(int a, int b, int c, int d, int e, ScoreId scoreId, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);

        // Act
        int result = _sut.CalculateScore(scoreId, wurf);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using ClassData
    [Theory]
    [ClassData(typeof(StronglyTypedScoringServiceTestDataSource))]
    public void CalculateScore_strongly_typed_parameterized_Test_using_ClassDataSource(Wurf wurf, ScoreId scoreId, int expected)
    {
        // Arrange

        // Act
        int result = _sut.CalculateScore(scoreId, wurf);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using strongly typed MemberData  
    [Theory]
    [MemberData(nameof(StronglyTypedTestDataSourceMemberFunction))]
    public void CalculateScore_strongly_typed_parameterized_Test_using_MemberData(Wurf wurf, ScoreId scoreId, int expected)
    {
        // Arrange

        // Act
        int result = _sut.CalculateScore(scoreId, wurf);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using MemberData 
    [Theory]
    [MemberData(nameof(TestDataSourceMemberFunction))]
    public void CalculateScore_parameterized_Test_using_MemberData(int a, int b, int c, int d, int e, ScoreId scoreId, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);

        // Act
        int result = _sut.CalculateScore(scoreId, wurf);

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
            new object[] { 1, 2, 3, 4, 3, ScoreId.SmallStraight, 30 },
            new object[] { 2, 3, 4, 5, 1, ScoreId.SmallStraight, 30 },
            new object[] { 1, 2, 3, 1, 3, ScoreId.SmallStraight, 0 },

            new object[] { 2, 3, 4, 5, 6, ScoreId.LargeStraight, 40 },
            new object[] { 1, 2, 3, 4, 5, ScoreId.LargeStraight, 40 },
            new object[] { 1, 2, 3, 4, 1, ScoreId.LargeStraight, 0 }
        };
    }


    /// <summary>
    ///     Static Member Function which returns the data for the [MemberData] parametrized Test
    /// </summary>
    public static TheoryData<Wurf, ScoreId, int> StronglyTypedTestDataSourceMemberFunction()
    {
        return new TheoryData<Wurf, ScoreId, int>
        {
            { new Wurf(6, 6, 6, 3, 1), ScoreId.ThreeOfAKind, 22 },
            { new Wurf(3, 3, 3, 3, 5), ScoreId.FourOfAKind, 17 }
        };
    }
}