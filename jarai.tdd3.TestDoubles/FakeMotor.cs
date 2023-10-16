using System.Diagnostics;

namespace jarai.tdd3.TestDoubles;

/// <summary>
///     "Fake" Implementierung von IMotor (z.B. zum Debuggen)
/// </summary>
public class FakeMotor : IMotor
{
    public void Anlassen()
    {
        Debug.WriteLine("Motor anlassen");
    }

    public void Abstellen()
    {
        Debug.WriteLine("Motor abstellen");
    }
}