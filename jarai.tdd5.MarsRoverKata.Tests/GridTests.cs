using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jarai.tdd5.MarsRoverKata.Tests;

[TestClass]
public class GridTests
{
    [TestMethod]
    public void HasObstacleTest()
    {
        // Arrange
        var target = new Grid();
        target.AddObstacle(new Position(0, 0));

        // Act
        bool actual = target.HasObstacle(new Position(0, 0));

        // Assert
        Assert.IsTrue(actual);
    }
}