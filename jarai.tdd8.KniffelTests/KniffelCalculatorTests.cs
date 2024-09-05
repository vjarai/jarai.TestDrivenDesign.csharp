using Xunit;

namespace jarai.tdd8.Kniffel.Legacy.Tests;

public class KniffelCalculatorTests
{
    [Fact]
    public void Chance_ShouldReturnSumOfAllDice()
    {
        // Arrange
        int d1 = 1, d2 = 2, d3 = 3, d4 = 4, d5 = 5;

        // Act
        int result = KniffelCalculator.Chance(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Kniffel_ShouldReturn50_WhenAllDiceAreSame()
    {
        // Arrange
        int[] dice = { 6, 6, 6, 6, 6 };

        // Act
        int result = KniffelCalculator.Kniffel(dice);

        // Assert
        Assert.Equal(50, result);
    }

    [Fact]
    public void Kniffel_ShouldReturn0_WhenNotAllDiceAreSame()
    {
        // Arrange
        int[] dice = { 6, 6, 6, 6, 5 };

        // Act
        int result = KniffelCalculator.Kniffel(dice);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Ones_ShouldReturnSumOfOnes()
    {
        // Arrange
        int d1 = 1, d2 = 2, d3 = 1, d4 = 4, d5 = 1;

        // Act
        int result = KniffelCalculator.Ones(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Twos_ShouldReturnSumOfTwos()
    {
        // Arrange
        int d1 = 2, d2 = 2, d3 = 1, d4 = 4, d5 = 2;

        // Act
        int result = KniffelCalculator.Twos(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Threes_ShouldReturnSumOfThrees()
    {
        // Arrange
        int d1 = 3, d2 = 3, d3 = 3, d4 = 4, d5 = 5;

        // Act
        int result = KniffelCalculator.Threes(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Fours_ShouldReturnSumOfFours()
    {
        // Arrange
        var kniffel = new KniffelCalculator(4, 4, 4, 4, 5);

        // Act
        int result = kniffel.Fours();

        // Assert
        Assert.Equal(16, result);
    }

    [Fact]
    public void Fives_ShouldReturnSumOfFives()
    {
        // Arrange
        var kniffel = new KniffelCalculator(5, 5, 5, 5, 5);

        // Act
        int result = kniffel.Fives();

        // Assert
        Assert.Equal(25, result);
    }

    [Fact]
    public void Sixes_ShouldReturnSumOfSixes()
    {
        // Arrange
        var kniffel = new KniffelCalculator(6, 6, 6, 6, 6);

        // Act
        int result = kniffel.Sixes();

        // Assert
        Assert.Equal(30, result);
    }


    [Fact]
    public void FourOfAKind_ShouldReturnSum_WhenFourOfAKind()
    {
        // Arrange
        int d1 = 2, d2 = 2, d3 = 2, d4 = 2, d5 = 5;

        // Act
        int result = KniffelCalculator.FourOfAKind(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void ThreeOfAKind_ShouldReturnSum_WhenThreeOfAKind()
    {
        // Arrange
        int d1 = 3, d2 = 3, d3 = 3, d4 = 4, d5 = 5;

        // Act
        int result = KniffelCalculator.ThreeOfAKind(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void SmallStraight_ShouldReturn15_WhenSmallStraight()
    {
        // Arrange
        int d1 = 1, d2 = 2, d3 = 3, d4 = 4, d5 = 5;

        // Act
        int result = KniffelCalculator.SmallStraight(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void LargeStraight_ShouldReturn20_WhenLargeStraight()
    {
        // Arrange
        int d1 = 2, d2 = 3, d3 = 4, d4 = 5, d5 = 6;

        // Act
        int result = KniffelCalculator.LargeStraight(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void FullHouse_ShouldReturnSum_WhenFullHouse()
    {
        // Arrange
        int d1 = 2, d2 = 2, d3 = 3, d4 = 3, d5 = 3;

        // Act
        int result = KniffelCalculator.FullHouse(d1, d2, d3, d4, d5);

        // Assert
        Assert.Equal(13, result);
    }
}