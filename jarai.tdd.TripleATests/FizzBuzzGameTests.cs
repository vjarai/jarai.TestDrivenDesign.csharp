using Xunit;

namespace jarai.tdd1.RedGreenRefactor.Tests
{
    public class FizzBuzzGameTests
    {
        [Fact()]
        public void GetResponse_when_1_then_1()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var result = game.GetResponse(1);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact()]
        public void GetResponse_when_3_then_Fizz()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var result = game.GetResponse(3);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Fact()]
        public void GetResponse_when_5_then_Buzz()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var result = game.GetResponse(5);

            // Assert
            Assert.Equal("Buzz", result);
        }

        [Fact()]
        public void GetResponse_when_15_then_FizzBuzz()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var result = game.GetResponse(15);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact()]
        public void GetResponse_when_negative_throws_ArgumentOutOfRangeException()
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => game.GetResponse(-1));

        }

        [Theory()]
        [InlineData(1, 1)]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void GetResponse(int input, object expected)
        {
            // Arrange
            var game = new FizzBuzzGame();

            // Act
            var result = game.GetResponse(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}