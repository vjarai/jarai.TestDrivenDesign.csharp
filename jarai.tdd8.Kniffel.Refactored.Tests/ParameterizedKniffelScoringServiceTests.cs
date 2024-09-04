using System.Collections.Generic;
using jarai.tdd8.KniffelRefactored.Tests.TestDataSources;
using Xunit;

namespace jarai.tdd8.KniffelRefactored.Tests;

public class ParameterizedKniffelScoringServiceTests
{
    
    // Parameterized Test using InlineData
    [Theory]
    [InlineData(1, 1, 1, 1, 1, ScoreId.Chance, 5)]
    [InlineData(4, 4, 4, 3, 3, ScoreId.FullHouse, 25)]
    public void CalculateScore_parameterized_Test_using_InlineData(int a, int b, int c, int d, int e, ScoreId scoreId, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, scoreId);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using ClassData
    [Theory]
    [ClassData(typeof(TestDataSourceClass))]
    public void CalculateScore_parameterized_Test_using_ClassDataSource(int a, int b, int c, int d, int e, ScoreId scoreId, int expected)
    {
        // Arrange
        var wurf = new Wurf(a, b, c, d, e);
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, scoreId);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using ClassData
    [Theory]
    [ClassData(typeof(StronglyTypedTestDataSourceClass))]
    public void CalculateScore_strongly_typed_parameterized_Test_using_ClassDataSource(Wurf wurf, ScoreId scoreId, int expected)
    {
        // Arrange
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, scoreId);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using strongly typed MemberData  
    [Theory]
    [MemberData(nameof(StronglyTypedTestDataSourceMemberFunction))]
    public void CalculateScore_strongly_typed_parameterized_Test_using_MemberData(Wurf wurf, ScoreId scoreId, int expected)
    {
        // Arrange
        var sut = new KniffelScoringService();

        // Act
        int result = sut.CalculateScore(wurf, scoreId);

        // Assert
        Assert.Equal(expected, result);
    }


    // Parameterized Test using MemberData 
    [Theory]
    [MemberData(nameof(TestDataSourceMemberFunction))]
    public void CalculateScore_parameterized_Test_using_MemberData(int a, int b, int c, int d, int e, ScoreId scoreId, int expected)
    {
        // Arrange
        var sut = new KniffelScoringService();
        var wurf = new Wurf(a, b, c, d, e);

        // Act
        int result = sut.CalculateScore(wurf, scoreId);

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
            new object[] { 1, 2, 3, 1, 3, ScoreId.SmallStraight, 0 },
            new object[] { 2, 3, 4, 5, 6, ScoreId.LargeStraight, 40 }
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