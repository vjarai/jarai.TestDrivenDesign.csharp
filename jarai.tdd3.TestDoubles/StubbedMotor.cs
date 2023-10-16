namespace jarai.tdd3.TestDoubles;

/// <summary>
///     "Leere" Implementierung von IMotor (ignoriert alle Aktionen)
/// </summary>
public class StubbedMotor : IMotor
{
    public void Anlassen()
    {
    }

    public void Abstellen()
    {
    }
}