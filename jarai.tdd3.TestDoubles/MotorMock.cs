namespace jarai.tdd3.TestDoubles;

/// <summary>
///     Ein Stub liefert "vorgefertigte" Ergebnisse 
/// </summary>
public class MotorMock : IMotor
{
    public bool _motorWurdeAngelassen;
    public bool _motorWurdeAbgestellt;

    public void Anlassen()
    {
        _motorWurdeAngelassen = true;
    }

    public void Abstellen()
    {
        _motorWurdeAbgestellt= true;
    }

    public int Drehzahl { get; set; } = 1000;
}