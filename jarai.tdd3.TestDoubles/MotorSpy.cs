namespace jarai.tdd3.TestDoubles;

/// <summary>
///     Ein Spy ermöglicht das "beobachten" eines internen Verhaltens 
/// </summary>
public class MotorSpy : IMotor
{
    public int AbstellenCounter { get; private set; }
    public int AnlassenCounter { get; private set; }

    public void Anlassen()
    {
        AnlassenCounter ++;
    }

    public void Abstellen()
    {
        AbstellenCounter++;
    }

    public int Drehzahl { get; set; } = 1000;
}