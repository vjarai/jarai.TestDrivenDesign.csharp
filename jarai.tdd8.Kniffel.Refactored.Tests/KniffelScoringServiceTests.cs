using Xunit;

namespace jarai.tdd8.KniffelRefactored.Tests
{
    public class KniffelScoringServiceTests
    {
        [Fact]
        public void Chance_ShouldReturnSumOfAllDice()
        {
            // Arrange
            var wurf = new Wurf(1, 2, 3, 4, 5);
            var sut = new KniffelScoringService();

            // Act
            var result = sut.Chance(wurf);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Kniffel_ShouldReturn50IfAllDiceAreSame()
        {
            // Arrange
            var wurf = new Wurf(6, 6, 6, 6, 6);
            var sut = new KniffelScoringService();


            // Act
            var result = sut.Kniffel(wurf);

            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Kniffel_ShouldReturn0IfNotAllDiceAreSame()
        {
            // Arrange
            var wurf = new Wurf( 6, 6, 6, 6, 5 );
            var sut = new KniffelScoringService();


            // Act
            var result = sut.Kniffel(wurf);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Ones_ShouldReturnSumOfOnes()
        {
            // Arrange
            var wurf = new Wurf(1, 2, 1, 4, 1);
            var sut = new KniffelScoringService();


            // Act
            var result = sut.Einer(wurf);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Twos_ShouldReturnSumOfTwos()
        {
            // Arrange
            var wurf = new Wurf( 2, 2, 1,  4,  2);
            var sut = new KniffelScoringService();


            // Act
            var result = sut.Zweier(wurf);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Threes_ShouldReturnSumOfThrees()
        {
            // Arrange
            var wurf = new Wurf( 3, 3, 3, 4, 5);
            var sut = new KniffelScoringService();


            // Act
            var result = sut.Dreier(wurf);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void Fours_ShouldReturnSumOfFours()
        {
            // Arrange
            var wurf = new Wurf( 4, 4, 4, 4, 5);
            var sut = new KniffelScoringService();

            // Act
            var result = sut.Vierer(wurf);

            // Assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void Fives_ShouldReturnSumOfFives()
        {
            // Arrange
            var wurf = new Wurf( 5, 5, 5, 5, 5);
            var sut = new KniffelScoringService();

            // Act
            var result = sut.Fuenfer(wurf);

            // Assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void Sixes_ShouldReturnSumOfSixes()
        {
            // Arrange
            var wurf = new Wurf( 6, 6, 6, 6, 6);
            var sut = new KniffelScoringService();

            // Act
            var result = sut.Sechser(wurf);

            // Assert
            Assert.Equal(30, result);
        }


        [Fact]
        public void FourOfAKind_ShouldReturnSumIfFourOfAKind()
        {
            // Arrange
            var wurf = new Wurf( 2, 2, 2, 2, 5);
            var sut = new KniffelScoringService();

            // Act
            var result = sut.Viererpasch(wurf);

            // Assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void ThreeOfAKind_ShouldReturnSumIfThreeOfAKind()
        {
            // Arrange
            var wurf = new Wurf( 3, 3, 3, 4, 5);
            var sut = new KniffelScoringService();


            // Act
            var result = sut.Dreierpasch(wurf);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void SmallStraight_ShouldReturn15IfSmallStraight()
        {
            // Arrange
            var wurf = new Wurf( 1, 2, 3, 4, 5);
            var sut = new KniffelScoringService();


            // Act
            var result = sut.KleineStrasse(wurf);

            // Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void LargeStraight_ShouldReturn20IfLargeStraight()
        {
            // Arrange
            var wurf = new Wurf( 2, 3, 4, 5, 6);
            var sut = new KniffelScoringService();
            
            // Act
            var result = sut.GrosseStrasse(wurf);

            // Assert
            Assert.Equal(40, result);
        }

        [Fact]
        public void FullHouse_ShouldReturnSumIfFullHouse()
        {
            // Arrange
            var wurf = new Wurf( 2, 2, 3, 3, 3);
            var sut = new KniffelScoringService();


            // Act
            var result = sut.FullHouse(wurf);

            // Assert
            Assert.Equal(25, result);
        }
    }
}