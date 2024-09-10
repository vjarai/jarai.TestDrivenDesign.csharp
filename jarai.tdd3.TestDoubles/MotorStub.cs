using System.Diagnostics;

namespace jarai.tdd3.TestDoubles;

/// <summary>
///     Ein Stub kann Daten für einen Test liefern, aber diesen nicht "rot" machen
/// </summary>
public class MotorStub : IMotor
{
    public void Anlassen()
    {
    }

    public void Abstellen()
    {
    }

    public int Drehzahl { get; set; } = 1000;
}