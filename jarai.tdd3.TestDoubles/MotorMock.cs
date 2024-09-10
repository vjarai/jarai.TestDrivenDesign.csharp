namespace jarai.tdd3.TestDoubles;

/// <summary>
///     Ein Mock kann Erwartungen prüfen und einen Test Rot machen
/// </summary>
public class MotorMock : IMotor
{
    public bool MotorWurdeAbgestellt { get; private set; }
    public bool MotorWurdeAngelassen { get; private set; }

    public void Anlassen()
    {
        MotorWurdeAngelassen = true;
    }

    public void Abstellen()
    {
        MotorWurdeAbgestellt = true;
    }

    public int Drehzahl { get; set; } = 1000;
}