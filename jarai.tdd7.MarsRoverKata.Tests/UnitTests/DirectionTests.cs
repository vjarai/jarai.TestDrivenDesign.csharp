using Xunit;

namespace jarai.tdd7.MarsRoverKata.Tests.UnitTests;

public class DirectionTests
{
    [Fact]
    public void Left_of_North_should_West()
    {
        var sut = NorthDirection.Instance;

        var actual = sut.TurnLeft();

        Assert.Equal(WestDirection.Instance, actual);
    }

    [Fact]
    public void Right_of_North_should_East()
    {
       var sut = NorthDirection.Instance;

       var actual = sut.TurnRight();

       Assert.Equal(EastDirection.Instance, actual);
    }


    [Fact]
    public void Left_of_East_should_North()
    {
        var sut = EastDirection.Instance;
        
        var actual = sut.TurnLeft();

        Assert.Equal(NorthDirection.Instance, actual);
    }

    [Fact]
    public void Right_of_East_should_South()
    {
       var sut = EastDirection.Instance;

       var actual = sut.TurnRight();

       Assert.Equal(SouthDirection.Instance, actual);
    }


    [Fact]
    public void Left_of_West_should_South()
    {
        var sut = WestDirection.Instance;
        
        var actual = sut.TurnLeft();

        Assert.Equal(SouthDirection.Instance, actual);
    }

    [Fact]
    public void Right_of_West_should_North()
    {
        var sut = WestDirection.Instance;
        Assert.IsType<NorthDirection>(sut.TurnRight());
    }


    [Fact]
    public void Left_of_South_should_East()
    {
        var sut = SouthDirection.Instance;
        
        var actual = sut.TurnLeft();

        Assert.Equal(EastDirection.Instance, actual);
    }

    [Fact]
    public void Right_of_South_should_West()
    {
       var sut = SouthDirection.Instance;
       
       var actual = sut.TurnRight();

       Assert.Equal(WestDirection.Instance, actual);
    }
}