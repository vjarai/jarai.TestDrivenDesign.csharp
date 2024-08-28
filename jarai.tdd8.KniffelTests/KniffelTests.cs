using Xunit;

namespace jarai.tdd8.KniffelKata.Tests
{
    public class KniffelTests
    {
        [Fact]
        public void Chance_ShouldReturnSumOfAllDice()
        {
            // Arrange
            int d1 = 1, d2 = 2, d3 = 3, d4 = 4, d5 = 5;

            // Act
            var result = Kniffel.Chance(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Yatzy_ShouldReturn50IfAllDiceAreSame()
        {
            // Arrange
            int[] dice = { 6, 6, 6, 6, 6 };

            // Act
            var result = Kniffel.yatzy(dice);

            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Yatzy_ShouldReturn0IfNotAllDiceAreSame()
        {
            // Arrange
            int[] dice = { 6, 6, 6, 6, 5 };

            // Act
            var result = Kniffel.yatzy(dice);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Ones_ShouldReturnSumOfOnes()
        {
            // Arrange
            int d1 = 1, d2 = 2, d3 = 1, d4 = 4, d5 = 1;

            // Act
            var result = Kniffel.Ones(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Twos_ShouldReturnSumOfTwos()
        {
            // Arrange
            int d1 = 2, d2 = 2, d3 = 1, d4 = 4, d5 = 2;

            // Act
            var result = Kniffel.Twos(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Threes_ShouldReturnSumOfThrees()
        {
            // Arrange
            int d1 = 3, d2 = 3, d3 = 3, d4 = 4, d5 = 5;

            // Act
            var result = Kniffel.Threes(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void Fours_ShouldReturnSumOfFours()
        {
            // Arrange
            var kniffel = new Kniffel(4, 4, 4, 4, 5);

            // Act
            var result = kniffel.Fours();

            // Assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void Fives_ShouldReturnSumOfFives()
        {
            // Arrange
            var kniffel = new Kniffel(5, 5, 5, 5, 5);

            // Act
            var result = kniffel.Fives();

            // Assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void Sixes_ShouldReturnSumOfSixes()
        {
            // Arrange
            var kniffel = new Kniffel(6, 6, 6, 6, 6);

            // Act
            var result = kniffel.sixes();

            // Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void ScorePair_ShouldReturnSumOfHighestPair()
        {
            // Arrange
            int d1 = 3, d2 = 3, d3 = 5, d4 = 4, d5 = 5;
            var kniffel = new Kniffel();

            // Act
            var result = kniffel.ScorePair(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void TwoPair_ShouldReturnSumOfTwoPairs()
        {
            // Arrange
            int d1 = 3, d2 = 3, d3 = 5, d4 = 4, d5 = 5;

            // Act
            var result = Kniffel.TwoPair(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void FourOfAKind_ShouldReturnSumIfFourOfAKind()
        {
            // Arrange
            int d1 = 2, d2 = 2, d3 = 2, d4 = 2, d5 = 5;

            // Act
            var result = Kniffel.FourOfAKind(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void ThreeOfAKind_ShouldReturnSumIfThreeOfAKind()
        {
            // Arrange
            int d1 = 3, d2 = 3, d3 = 3, d4 = 4, d5 = 5;

            // Act
            var result = Kniffel.ThreeOfAKind(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void SmallStraight_ShouldReturn15IfSmallStraight()
        {
            // Arrange
            int d1 = 1, d2 = 2, d3 = 3, d4 = 4, d5 = 5;

            // Act
            var result = Kniffel.SmallStraight(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void LargeStraight_ShouldReturn20IfLargeStraight()
        {
            // Arrange
            int d1 = 2, d2 = 3, d3 = 4, d4 = 5, d5 = 6;

            // Act
            var result = Kniffel.LargeStraight(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void FullHouse_ShouldReturnSumIfFullHouse()
        {
            // Arrange
            int d1 = 2, d2 = 2, d3 = 3, d4 = 3, d5 = 3;

            // Act
            var result = Kniffel.FullHouse(d1, d2, d3, d4, d5);

            // Assert
            Assert.Equal(13, result);
        }
    }
}