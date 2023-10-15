using Xunit;

namespace jarai.tdd1.RedGreenRefactor.Tests;

public class FizzBuzzGameTests
{
    [Fact]
    public void GetResponse_when_1_then_1()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(1);

        // Assert
        Assert.Equal(1, actual);
    }

    [Fact]
    public void GetResponse_when_3_then_Fizz()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(3);

        // Assert
        Assert.Equal("Fizz", actual);
    }

    [Fact]
    public void GetResponse_when_5_then_Buzz()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(5);

        // Assert
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void GetResponse_when_15_then_FizzBuzz()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(15);

        // Assert
        Assert.Equal("FizzBuzz", actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(101)]
    public void GetResponse_when_less_then_1_or_bigger_then_100_throws_ArgumentOutOfRangeException(int input)
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        Assert.Throws<ArgumentOutOfRangeException>(() => game.GetResponse(input));
    }

    /// <summary>
    ///     Parametrisierter Test: Deckt alle einfachem Testfälle in einem einzigen Test ab
    /// </summary>
    [Theory]
    [InlineData(1, 1)]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void GetResponse(int input, object expected)
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}