using Xunit;

namespace jarai.tdd7.MarsRoverKata.Tests.UnitTests;

public class DirectionTests
{
    [Fact]
    public void Left_of_North_should_West()
    {
        var sut = new NorthDirection();
        Assert.IsType<WestDirection>(sut.TurnLeft());
    }

    [Fact]
    public void Right_of_North_should_East()
    {
       var sut = new NorthDirection();
        Assert.IsType<EastDirection>(sut.TurnRight());
    }


    [Fact]
    public void Left_of_East_should_North()
    {
        var sut = new EastDirection();
        Assert.IsType<NorthDirection>(sut.TurnLeft());
    }

    [Fact]
    public void Right_of_East_should_South()
    {
       var sut = new EastDirection();
        Assert.IsType<SouthDirection>(sut.TurnRight());
    }


    [Fact]
    public void Left_of_West_should_South()
    {
        var sut = new WestDirection();
        Assert.IsType<SouthDirection>(sut.TurnLeft());
    }

    [Fact]
    public void Right_of_West_should_North()
    {
        var sut = new WestDirection();
        Assert.IsType<NorthDirection>(sut.TurnRight());
    }


    [Fact]
    public void Left_of_South_should_East()
    {
        var sut = new SouthDirection();
        Assert.IsType<EastDirection>(sut.TurnLeft());
    }

    [Fact]
    public void Right_of_South_should_West()
    {
       var sut = new SouthDirection();
        Assert.IsType<WestDirection>(sut.TurnRight());
    }
}