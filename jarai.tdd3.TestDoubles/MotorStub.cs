using System.Diagnostics;

namespace jarai.tdd3.TestDoubles;

/// <summary>
///     "Fake" Implementierung von IMotor mit eingeschränkter Funktionalität
/// </summary>
public class MotorStub : IMotor
{
    public void Anlassen()
    {
        Debug.WriteLine("Motor anlassen");
    }

    public void Abstellen()
    {
        Debug.WriteLine("Motor abstellen");
    }

    public int Drehzahl { get; set; } = 1000;
}