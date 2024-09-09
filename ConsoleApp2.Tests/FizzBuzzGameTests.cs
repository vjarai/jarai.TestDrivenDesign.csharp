using Xunit;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Xunit.Assert;

namespace ConsoleApp2.Tests
{
    public class FizzBuzzGameTests
    {
        [Fact()]
        public void FizzBuzzTest()
        {
            // Arrange
            var sut = new FizzBuzzGame();

            // Act
            var actual = sut.FizzBuzz(3);

            // Assert
            Assert.Equal("Fizz", actual);
        }
    }
}