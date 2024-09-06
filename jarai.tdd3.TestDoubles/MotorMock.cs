namespace jarai.tdd3.TestDoubles;

/// <summary>
///     Ein Stub liefert "vorgefertigte" Ergebnisse
/// </summary>
public class MotorMock : IMotor
{
    public bool _motorWurdeAbgestellt;
    public bool _motorWurdeAngelassen;

    public void Anlassen()
    {
        _motorWurdeAngelassen = true;
    }

    public void Abstellen()
    {
        _motorWurdeAbgestellt = true;
    }

    public int Drehzahl { get; set; } = 1000;
}